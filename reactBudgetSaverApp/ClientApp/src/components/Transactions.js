import React, { Component } from 'react';
import './Transactions.css';

export class Transactions extends Component {
  static displayName = Transactions.name;

  constructor(props) {
    super(props);
    this.state = { transactions: [], loading: true };
  }

  componentDidMount() {
    this.populateTransactionData();
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
                  {transaction.transactType == '0' ? <td>{'+ ' + transaction.amount}</td> : <td>{'- ' + transaction.amount}</td>}
                  <td>{transaction.category}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
    }


  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Transactions.renderTransactionsTable(this.state.transactions);

    return (
      <div>
        <h1 id="tabelLabel" >Transaction list</h1>
        <p>This table shows total list of all transactions.
            Green color indicates Income and Red indicates Expenses.</p>
        {contents}
      </div>
    );
  }

  async populateTransactionData() {
      const response = await fetch('transaction');
      const data = await response.json();
      console.log(data);
      this.setState({ transactions: data, loading: false });
  }
}
