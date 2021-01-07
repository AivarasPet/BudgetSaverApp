import React, { Component } from 'react';
import './Transactions.css';
import AddTransaction from './AddTransaction.js'


export class Transactions extends Component {
    static displayName = Transactions.name;

    constructor(props) {
        super(props);
        this.state = {
            transactions: [],           
            loading: 0,
            popularTransactions: [],
        };
    }

    componentDidMount() {
        this.populateTransactionData();
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


    render() {
        let contents;
        switch (this.state.loading) {
            case 1: contents = Transactions.renderTransactionsTable(this.state.transactions);
                break;
            case 2: contents = Transactions.renderPopularTransactionsTable(this.state.popularTransactions);
                break;
            default: contents = < p > <em>Loading...</em></p >;
                break;
        };
        return (
            <div>
                <AddTransaction onUpdate={this.onUpdate.bind(this)} />
                <h1 id="tabelLabel" >Transaction list</h1>
                <p>This table shows total list of all transactions.</p>
                <button onClick={this.populateTransactionData} style={{ marginRight: 10 }}>Standart transactions</button>
                <button onClick={this.populatePopularTransactions}>Popular transactions</button>

                {contents}
            </div>
        );

    }

    onUpdate(data) {
        var transactions = this.state.transactions;
        transactions.push(data);
        this.setState({ transactions: transactions });
    }

    populateTransactionData = async() => {
        const response = await fetch('transaction');
        const data = await response.json();
        console.log(data);
        this.setState({ transactions: data, loading: 1 });
    }

    populatePopularTransactions = async () => {
        const response = await fetch('Transaction/PostPopularTransactions');
        const data = await response.json();
        console.log(data);
        this.setState({ popularTransactions: data,  loading: 2 });
    }

    //handlePopularTransaction = (event) => {
        /*event.preventDefault();
        var data = 'true';
        const x = this.state.isOn ? false : true;

        const message = {
            method: 'post',
            body: { isOn: x }
        };

        fetch('Transaction/PostCheckPopularTransaction', message)
            .then(response => {
                if (response.ok) {
                    return response.json();
                } else {
                    response.text().then((s) => window.alert(s));//cia reiks fixint kad butu reactinis solutionas
                    return null;
                }
            }).then(data => {
                if (data !== null) {
                    this.props.populatePopularTransactions();
                }

            });*/
    //}

    static renderPopularTransactionsTable(popularTransactions) {

        return (
            <table className='table table-bordered table-sm table-hover table-striped' aria-labelledby="tabelLabel1" sortable="true">
                <thead className="thead-dark">
                    <tr>
                        <th>Category</th>
                        <th>Count</th>
                    </tr>
                </thead>
                <tbody>
                    {popularTransactions.map((popularTransactions, index) =>
                        <tr>
                            <td>{popularTransactions.item1.title}</td>
                            <td>{popularTransactions.item2}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }
}
