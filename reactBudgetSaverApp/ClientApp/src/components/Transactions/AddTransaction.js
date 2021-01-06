import React, { Component } from 'react';
import Select from 'react-select';
//import Popup from 'react-popup';

export default class AddTransaction extends Component {
    static displayName = AddTransaction.name;

    constructor(props) {
        super(props);
        this.state = {
            addNewTransactionVisibility: false,
            inputType: "",
            inputCategory: "",
            inputTitle: "",
            inputAmount: NaN
        };

        this.type = [
            { value: 0, label: 'Income' },
            { value: 1, label: 'Expenses' }
        ];

        this.categories = [];
    }

    componentDidMount() {
        this.populateCategories();
    }

    handleAmountChange = (event) => {
        this.setState({ inputAmount: event.target.value });
    }

    handleTitleChange = (event) => {
        this.setState({ inputTitle: event.target.value });
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

        //verification
        if (this.state.inputType === "" || this.state.inputAmount === NaN || this.state.inputTitle === "" || this.state.inputCategory === "") {
            return;
        }

        var data = { transactType: this.state.inputType, amount: parseFloat(this.state.inputAmount), title: this.state.inputTitle, category: this.state.inputCategory };
        console.log(data);
        this.clearAdd();

        const message = {
            method: 'post',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
        };

        fetch('Transaction/PostAddTransaction', message)
            .then(response => {
                if (response.ok) {
                    return response.json();
                } else {
                    response.text().then((s) => window.alert(s));//cia reiks fixint kad butu reactinis solutionas
                    return null;
                }
            }).then(data => {
                if (data !== null) {
                    this.props.onUpdate(data);
                }
                    
            });
    }

    toggleVisilibity = () => {
        this.setState({
            addNewTransactionVisibility: !this.state.addNewTransactionVisibility
        });
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

    render() {
        return (
            <div>           
                <button className="btn btn-primary" onClick={this.toggleVisilibity}>Add Transaction</button>
                {this.state.addNewTransactionVisibility && (
                    <form onSubmit={this.handleNewTransaction}>{"\n"}
                        <Select type="type" options={this.type} onChange={this.handleTypeChange} />
                        <input type="text" placeholder="  Title" onChange={this.handleTitleChange} style={{ width: "100%", height: 37 }} />
                        <input type="number" min="0" step="any" placeholder="  Amount" onChange={this.handleAmountChange} style={{ width: "100%", height: 37 }} />
                        <Select placeholder="Category" options={this.categories} onChange={this.handleCategoryChange} />
                        <input type="submit" value="Add" style={{ width: "140px", height: 37 }} />
                    </form>
                )}               
            </div>

        );
        
    }  
}
