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
            <div>
                <button>Edit</button>
                <table className='table table-bordered table-sm table-hover table-striped' aria-labelledby="tabelLabel">
                    <thead className="thead-dark">
                        <tr>
                            <th style={{ width: '4%' }}>Logo</th>
                            <th>Title</th>
                            <th>Amount</th>
                            <th>Value {'\u0024'}</th>
                        </tr>
                    </thead>
                    <tbody>
                        {possessions.map((possession, index) =>
                            <tr key={index}>
                                <td><img src={possession.imageUrl} className = "image" /></td>
                                <td>{possession.name}</td>
                                <td>{possession.amount}</td>
                                <td>{possession.valueInDollarsWhenBought}</td>
                            </tr>
                        )}
                    </tbody>
                </table>
            </div>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Possessions.renderPossessionsTable(this.state.possessions);

        return (
            <div>
                <h1 id="tabelLabel" >Possesion list</h1>
                <p>This table shows total list of all possessions.</p>
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
