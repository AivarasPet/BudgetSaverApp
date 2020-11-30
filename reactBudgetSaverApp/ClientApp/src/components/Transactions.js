import React, { Component } from 'react';
import './Transactions.css';
import Select from 'react-select';

export class Transactions extends Component {
    static displayName = Transactions.name;

    constructor(props) {
        super(props);
        this.state = {
            transactions: [],
            loading: true,
            addNewTransactionVisibility: false,
            placeHolder: "Title",
            inputType: "",
            inputCategory: "",
            sortedBy: "",
            sortDirection: 0
        };

        this.type = [
            { value: 0, label: 'Income' },
            { value: 1, label: 'Expenses' }
        ];

        this.categories = [];

        this.inputTitle = React.createRef();
        this.inputAmount = React.createRef();
    }

    componentDidMount() {
        this.populateTransactionData();
        this.populateCategories();
    }

    static renderTransactionsTable(transactions) {
        return (
            <table className='table table-bordered table-sm table-hover table-striped' aria-labelledby="tabelLabel" sortable="true">
                <thead className="thead-dark">
                    <tr>
                        <th data-field="id" data-sortable="true">Title</th>
                        <th data-field="id" data-sortable="true">Amount {'\u20AC'}</th>
                        <th>Category</th>
                    </tr>
                </thead>
                <tbody>
                    {transactions.map((transaction, index) =>
                        <tr key={index} typeforcss={transaction.transactType}>
                            <td>{transaction.title}</td>
                            {transaction.transactType === 0 ? <td>{'+ ' + transaction.amount}</td> : <td>{'- ' + transaction.amount}</td>}
                            <td>{transaction.category}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    handleTypeChange = (event) => {
        this.setState({ inputType: event.value });
    }

    handleCategoryChange = (event) => {
        this.setState({ inputCategory: event.value });
    }

    clearAdd = () => {
        this.setState({ inputCategory: "", inputType: "", addNewTransactionVisibility: false });
        this.setState({});
        this.inputAmount = "";
        this.inputTitle = "";
    }

    handleNewTransaction = (event) => {
        // Simple POST request with a JSON body using fetch
        event.preventDefault();


        var data = { transactType: this.state.inputType, amount: parseFloat(this.inputAmount.current.value), title: this.inputTitle.current.value, category: this.state.inputCategory };
        console.log(data);

        this.clearAdd();

        const message = {
            method: 'post',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
        };

        fetch('Transaction/PostAddTransaction', message)
            .then(response => response.json())
            .then(data => {
                var transactions = this.state.transactions;
                transactions.push(data);
                this.setState({ transactions: transactions });

            });


    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Transactions.renderTransactionsTable(this.state.transactions);
        return (
            <div>
                <button className="btn btn-primary" onClick={this.toggleVisilibity}>Add Transaction</button>
                {this.state.addNewTransactionVisibility && (
                    <form onSubmit={this.handleNewTransaction}>
                        <p></p>
                        <p><Select placeholder="Transaction type" options={this.type} onChange={this.handleTypeChange} /></p>
                        <p><input type="text" placeholder="  Title" ref={this.inputTitle} style={{ width: "100%", height: 37 }} /></p>
                        <p><input type="number" min="0" step="any" placeholder="  Amount" ref={this.inputAmount} style={{ width: "100%", height: 37 }} /></p>
                        <p><Select placeholder="Category" options={this.categories} onChange={this.handleCategoryChange} /></p>
                        <p><input type="submit" value="Add" style={{ width: "140px", height: 37 }} /></p>
                    </form>
                )}
                <h1 id="tabelLabel" >Transaction list</h1>
                <p>This table shows total list of all transactions.</p>
                {contents}
            </div>
        );
    }


    toggleVisilibity = () => {
        this.setState({
            addNewTransactionVisibility: !this.state.addNewTransactionVisibility
        });
    }

    async populateTransactionData() {
        const response = await fetch('transaction');
        const data = await response.json();
        console.log(data);
        this.setState({ transactions: data, loading: false });
    }

    async populateCategories() {
        const response = await fetch('categories/getcategories');
        const data = await response.json();
        console.log(data);
        var tempCategories = [];
        data.forEach(function (element) {
            tempCategories.push({ label: element.name, value: element.name })
        });

        this.categories = tempCategories;
    }
}
