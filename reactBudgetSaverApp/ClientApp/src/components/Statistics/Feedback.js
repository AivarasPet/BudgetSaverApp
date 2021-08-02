import React, { Component } from 'react';
import Select from 'react-select';
import "./Feedback.css"


export default class Feedback extends Component {
    static displayName = Feedback.name;

    constructor(props) {
        super(props);
        this.state = {
            feedback: [],
            loading: true
        };

    }




    render() {
        var array = this.props.feedbackData;
        return (
            <div>
                <h1>Feedback</h1> 
                <h4>Last Month vs Current Month</h4>
                <table className='table table-bordered table-sm table-hover table-striped feedbackTable' aria-labelledby="tabelLabel" sortable="true">
                    <thead className="thead-dark">
                        <tr>
                            <th data-field="id" >Category</th>
                            <th>Difference </th>
                            <th>Percentage Difference</th>
                            <th>Did you improve?</th>
                        </tr>
                    </thead>
                    <tbody>
                        {array.map((item, index) =>
                            <tr key={index} typeforcss={(item.isFeedbackPositive == true ? "0" : "1")}>
                                <td>{item.category}</td>
                                {item.isFeedbackPositive == true ? <td>{'+ ' + item.difference + ' \u20AC'}</td> : <td>{'- ' + item.difference + ' \u20AC'}</td>}
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
