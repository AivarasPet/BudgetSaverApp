import React, { Component } from 'react';

export class Statistics extends Component {
    static displayName = Statistics.name;

  constructor(props) {
    super(props);
      this.state = {
          currentCount: 0, statistic: {}, loading: true
      };
      this.thisWeek = this.thisWeek.bind(this);
      this.lastWeek = this.lastWeek.bind(this);
      this.thisMonth = this.thisMonth.bind(this);
      this.lastMonth = this.lastMonth.bind(this);
  }

    async thisWeek() {
        const response = await fetch('statistic/thisweek');
        const data = await response.json();
        console.log(data);
        this.setState({ statistic: data, loading: false });
    }

    async lastWeek() {
        const response = await fetch('statistic/lastweek');
        const data = await response.json();
        console.log(data);
        this.setState({ statistic: data, loading: false });
    }

    async thisMonth() {
        const response = await fetch('statistic/thismonth');
        const data = await response.json();
        console.log(data);
        this.setState({ statistic: data, loading: false });
    }

    async lastMonth() {
        const response = await fetch('statistic/lastmonth');
        const data = await response.json();
        console.log(data);
        this.setState({ statistic: data, loading: false });
    }


    static renderStatistic(statistics) {
        return (
            <div>
                <div>Transaction amount: {statistics.transactionAmount}</div>
                <div>Income: {statistics.income}</div>
                <div>Expenses: {statistics.expenses}</div>
                <div>Balance: {statistics.income - statistics.expenses}</div>
                <div>Most frequent category: {statistics.frequentCategory}</div>
            </div>
        );


    }


    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Statistics.renderStatistic(this.state.statistic);
        return (
            <div>
                <h1>Statistics</h1>
                <div>
                    <button onClick={this.thisWeek}>This Week</button>
                    <button onClick={this.lastWeek}>Last Week</button>
                    <button onClick={this.thisMonth}>This Month</button>
                    <button onClick={this.lastMonth}>Last Month</button>
                </div>

                {contents}
                
            </div>
        );
      }
    }
