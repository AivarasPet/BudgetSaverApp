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
          addNewTransactionVisibility: true,
          placeHolder: "Title"
      };
      this.toggleVisilibity = this.toggleVisilibity.bind(this);
      this.type = [
          { value: 0, label: 'Income' },
          { value: 1, label: 'Expenses' }
      ];

      this.categories = [];
  }

  componentDidMount() {
      this.populateTransactionData();
      this.populateCategories();
  }

  static renderTransactionsTable(transactions) {
    return (
        <table className='table table-bordered table-sm table-hover table-striped' aria-labelledby="tabelLabel">
        <thead class="thead-dark">
          <tr>
            <th>Title</th>
            <th>Amount {'\u20AC'}</th>
            <th>Category</th>
          </tr>
        </thead>
        <tbody>
          {transactions.map((transaction,index) =>
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

    handleNewTransaction = (event) => {
        // Simple POST request with a JSON body using fetch
        const requestOptions = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(event.target)
        };

        console.log(event.target);
        fetch('Transactions/AddTransaction', requestOptions);


    }

    render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Transactions.renderTransactionsTable(this.state.transactions);
      return (

          <div>
              <button className="btn btn-primary" onClick={this.toggleVisilibity}>Add Transaction</button>
              {!this.state.addNewTransactionVisibility && (
                  <form onSubmit={this.handleNewTransaction}>
                      
                      <Select options={this.type} />
                      <input type="text" placeholder="Title"/>
                      <input type="number" min="0" step="any" placeholder="Amount" />
                      <Select options={this.categories} />
                      <input type="submit" value="Add"/>
                  </form>
              )}
              <h1 id="tabelLabel" >Transaction list</h1>
        <p>This table shows total list of all transactions.
            Green color indicates Income and Red indicates Expenses.</p>
        {contents}
      </div>
    );
    }


    toggleVisilibity() {
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
        data.forEach(function (element){
            tempCategories.push({label:element.name,value:element.name})
        });

        this.categories = tempCategories;
    }
}
