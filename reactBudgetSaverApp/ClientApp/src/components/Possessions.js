import React, { Component } from 'react';
import './Possessions.css';

export class Possessions extends Component {
    static displayName = Possessions.name;

  constructor(props) {
    super(props);
    this.state = { possessions: [], loading: true };
  }

  componentDidMount() {
    this.populatePossessionData();
  }

  static renderPossessionsTable(possessions) {
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
          {possessions.map((possession,index) =>
              <tr key={index} typeforcss={possession.possessionsType}>
                  <td>{possession.title}</td>
                  <td>{possession.amount}</td>
                  <td>{possession.category}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
    }

  render() {
    let contents = this.state.loading
        ? <p><em>Loading...</em></p>
        : Possessions.renderPossessionsTable(this.state.possessions);

    return (
      <div>
        <h1 id="tabelLabel" >Possesion list</h1>
        <p>This table shows total list of all transactions.
            Green color indicates Income and Red indicates Expenses.</p>
        {contents}
      </div>
    );
  }

  async populatePossessionData() {
      const response = await fetch('possession');
      const data = await response.json();
      console.log(data);
      this.setState({ possessions: data, loading: false });
  }
}
