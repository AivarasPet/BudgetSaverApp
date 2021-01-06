import React, { Component } from 'react';
import Select from 'react-select';
//import Popup from 'react-popup';

export default class Feedback extends Component {
    static displayName = Feedback.name;

    constructor(props) {
        super(props);
        this.state = {
            feedback: [],
            loading: true
        };

    }

    componentDidMount() {
        this.getFeedback();
    }

    async getFeedback() {
        const response = await fetch('statistic/getpreviousmonthfeedback');
        const data = await response.json();
        console.log(data);
        this.setState({ feedback: data, loading: false });
    }

    render() {
        return (
            <div>
                <table className='table table-bordered table-sm table-hover table-striped' aria-labelledby="tabelLabel" sortable="true">
                    <thead className="thead-dark">
                        <tr>
                            <th data-field="id" >Category</th>
                            <th>Difference </th>
                            <th>Percentage Difference</th>
                            <th>Did you improve?</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.feedback.map((item, index) =>
                            <tr key={index}>
                                <td>{item.category}</td>
                                <td>{item.difference}</td>
                                <td>{Number((item.percentageDifference).toFixed(2))}</td>
                                {item.isFeedbackPositive == true ? <td>{"Yes IT's GOOD"}</td> : <td>{"NO IT's BAD"}</td>}
                            </tr>
                        )}
                    </tbody>
                </table>
            </div>

        );
        
    }

    
}
