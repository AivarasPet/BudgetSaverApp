import React, { Component } from 'react';
import Select from 'react-select';
import './Feedback.css';

export default class Feedback extends Component {
    static displayName = Feedback.name;

    constructor(props) {
        super(props);
        this.state = {
            feedback: [],
            date1: [],
            date2: [],
            loading: true,       
        };
    }

    async getFeedback() {
        const response = await fetch('statistic/getpreviousmonthfeedback');
        const data = await response.json();
        console.log(data);
        this.setState({ feedback: data, date1: data[0].formatedDateTo, date2: data[0].formatedDate, loading: false });
    }

    componentDidMount() {
        this.getFeedback();
    }

    render() {
        return (
            <div>
                <p>Compared between {this.state.date1} and {this.state.date2}</p>
                <table className='table table-bordered table-sm table-hover table-striped feedbackTable' aria-labelledby="tabelLabel1" sortable="true">
                    <thead className="thead-dark">
                        <tr>
                            <th data-field="id">Category</th>
                            <th>Difference </th>
                            <th>Percentage difference</th>
                            <th>Did you improve?</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.feedback.map((item, index) =>
                            <tr key={index} typeforcss={(item.isFeedbackPositive == true ? "0" : "1") + (item.IsExpenses == true ? "1" : "0")}>
                                <td>{item.category}</td>
                                {item.IsExpenses == true ? <td>{'- ' + item.difference + ' \u20AC'}</td> : <td>{'+ ' + item.difference + ' \u20AC'}</td>}
                                <td>{Math.round(item.percentageDifference)}</td>
                                {item.isFeedbackPositive == true ? <td>{"Yes IT's GOOD"}</td> : <td>{"NO IT's BAD"}</td>}
                            </tr>
                        )}
                    </tbody>
                </table>
            </div>
        );
    }    
}