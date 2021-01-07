import React, { Component } from 'react';
import Chart from 'chart.js';

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
   
    thisMonth = async () => {
        const response = await fetch('statistic/thismonth');
        const data = await response.json();
        console.log(data.subStatsList);
        for (var i = 0; i < data.subStatsList.length; i++) {
            var joined1 = this.state.labels.concat(data.subStatsList[i].category);
            if (data.subStatsList[i].isIncome) { var joined2 = this.state.dataValues.concat(data.subStatsList[i].amount); }
            else { var joined2 = this.state.dataValues.concat((data.subStatsList[i].amount)*-1); }
            this.setState({ labels: joined1, dataValues: joined2 })
        }
        this.setState({ loading: false });
        this.buildChart(this.state.labels, this.state.dataValues);
    }
 
    componentDidMount() {
        this.thisMonth();
    }

    buildChart = (labels, dataValues) => {
        var myChart;
        if (myChart) {
            window.myChart.destroy();
        }
        var ctx = this.ctx;
        myChart = new Chart(ctx, {
            type: "bar",
            data: {
                labels: labels,
                datasets: [
                    {
                        label: "ammount, \u20AC",
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
                            suggestedMin: 0,
                            suggestedMax: 500
                        }
                    }]
                }
            }
        });
    }
    
    render() {   
        return (
            <div>
                <h1>Home</h1>
                <p>This month's statistics</p>
                <div>
                    <canvas width='700' height='200' ref={ctx => (this.ctx = ctx)} />
                </div>
            </div>
        );
    }
}
