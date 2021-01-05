import React, { Component } from 'react';
import Chart from 'chart.js'
import Feedback from "./Feedback.js";

export class Home extends Component {
    static displayName = Home.name;
    constructor(props) {
        super(props);
        this.state = {
            labels: [],
            dataValues: [],
            loading: true,
        };
    }

    async getFeedback() {
        const response = await fetch('statistic/getpreviousmonthfeedback');
        const data = await response.json();
        console.log(data);
        for (var i = 0; i < data.length; i++) {
            var joined1 = this.state.labels.concat(data[i].category);
            var joined2 = this.state.dataValues.concat(data[i].percentageDifference);
            this.setState({ labels: joined1, dataValues: joined2 })
        }
        this.setState({ loading: false });
    }
    componentDidMount() {
        this.getFeedback();
    }
    componentDidUpdate() {
        this.buildChart(this.state.labels, this.state.dataValues);
    }

    buildChart = (labels, dataValues) => {
        const ctx = this.ctx;
        console.log(dataValues);
        new Chart(ctx, {
            type: "bar",
            data: {
                labels: labels,
                datasets: [
                    {
                        label: "% difference",
                        data: dataValues,
                        backgroundColor: [                           
                            "rgba(255, 99, 132, 0.2)",
                            "rgba(54, 162, 235, 0.2)",
                            "rgba(255, 206, 86, 0.2)",
                            "rgba(62, 231, 252, 0.2)",
                            "rgba(243, 62, 252, 0.2)",
                            "rgba(62, 252, 140, 0.2)",
                            "rgba(252, 201, 62, 0.2)",
                        ]
                    },
                ]
            },
            options: {
                scales: {
                    yAxes: [{
                        display: true,
                        ticks: {
                            suggestedMin: 0
                        }
                    }]
                }
            }
        });
    }

    render() {
        return (
            <div>  
                <h1>Feedback</h1>
                <canvas width='800' height='300' ref={ctx => (this.ctx = ctx)} />
            </div>
        );
    }
}
