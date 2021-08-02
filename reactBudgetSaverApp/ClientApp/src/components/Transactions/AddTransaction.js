import React, { Component } from 'react';
import Select from 'react-select';
import * as axios from 'axios';
import * as AuthService from './../UserAuthentication/AuthService' 
//import Popup from 'react-popup';

var axiosInstance = axios.create({
    baseURL: 'https://localhost:5001/Tramsaction',
    headers: {'Authorization': 'Bearer ' + localStorage.getItem('token')}
})


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

        this.expensesCategories = [];
        this.incomeCategories = [];
        this.date = React.createRef();
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
        console.log(event.value + " ok ");
        this.setState({ inputType: event.value });
    }

    handleCategoryChange = (event) => {
        this.setState({ inputCategory: event.value });
    }
    handleDateChange = (event) => {
        this.setState({ inputDate: event.value });
    }




    clearAdd = () => {
        this.setState({ inputCategory: "", inputType: "", addNewTransactionVisibility: false });
        this.setState({});
        this.inputAmount = "";
        this.inputTitle = "";
    }

    handleNewTransaction = async (event) => {
        // Simple POST request with a JSON body using fetch
        event.preventDefault();

        //verification
        if (this.state.inputType === "" || this.state.inputAmount === NaN || this.state.inputTitle === "" || this.state.inputCategory === "" || this.date.current.value === undefined) {
            return;
        }

        var data = { transactType: this.state.inputType, amount: parseFloat(this.state.inputAmount), title: this.state.inputTitle, category: this.state.inputCategory, date:  this.date.current.value };


        console.log(data);

        this.clearAdd();

        console.log("JWT TOken " + AuthService.getToken());

        const message = {
            method: 'post',
            headers: { 'Content-Type': 'application/json', 'Authorization': 'Bearer ' + AuthService.getToken()},
            body: JSON.stringify(data)
        };


        // try {
        //     await axiosInstance.post('/PostAddTransaction', data);
        // } catch {
        //     console.log("bybiene");
        // }



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
        const response = await fetch('categories/getTransactionCategories');
        const data = await response.json();
        console.log(data);
        var tempCategories = [];
        var temp = [];
        tempCategories = data.expensesCategories;
        tempCategories.forEach(function (element) {
            temp.push({ label: element.name, value: element.name })
        });
        this.expensesCategories = temp;
        temp = [];
        tempCategories = data.incomeCategories;
        tempCategories.forEach(function (element) {
            temp.push({ label: element.name, value: element.name })
        });
        this.incomeCategories = temp;
        // data.expensesCategories.forEach(function (element) {
        //     this.expensesCategories.push({ label: element.name, value: element.name })
        // });
    }

    render() {
        let categories = (this.state.inputType === 0) ? (this.incomeCategories) : (this.expensesCategories);
        return (
            <div>
                
                <button className="btn btn-primary" onClick={this.toggleVisilibity}>Add Transaction</button>
                {this.state.addNewTransactionVisibility && (
                    <form onSubmit={this.handleNewTransaction}>{"\n"}
                        <Select type="type" options={this.type} onChange={this.handleTypeChange} />
                        <input type="text" placeholder="  Title" onChange={this.handleTitleChange} style={{ width: "100%", height: 37 }} />
                        <input type="number" min="0" step="any" placeholder="  Amount" onChange={this.handleAmountChange} style={{ width: "100%", height: 37 }} />
                        <Select placeholder="Category" options={categories} onChange={this.handleCategoryChange} />
                        <input type="date"  className="form-control" ref={this.endDate} ref={this.date} style={{ width: "100%", height: 37}}></input>
                        <input type="submit" value="Add" style={{ width: "140px", height: 37 }} />
                    </form>
                )}               
            </div>

        );
        
    }  
}
