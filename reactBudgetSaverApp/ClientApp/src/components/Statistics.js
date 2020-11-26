import React, { Component } from 'react';
import "./Statistics.css"

export class Statistics extends Component {
    static displayName = Statistics.name;

  constructor(props) {
    super(props);
      this.state = {
          currentCount: 0, statistic: {}, loading: true,
          setStatisticsDateVisibility: false
      };
      this.toggleVisilibity = this.toggleVisilibity.bind(this);
      this.thisWeek = this.thisWeek.bind(this);
      this.lastWeek = this.lastWeek.bind(this);
      this.thisMonth = this.thisMonth.bind(this);
      this.lastMonth = this.lastMonth.bind(this);
      this.thisWeek();
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
            <ul>
                <p></p>
                <div>
                    <li>Transaction amount: {statistics.transactionAmount}</li>
                    <li>Income: + {statistics.totalIncome} {'\u20AC'}</li>
                    <li>Expenses: - {statistics.totalExpenses} {'\u20AC'}</li>
                    <li>Balance: {statistics.totalIncome - statistics.totalExpenses} {'\u20AC'}</li>
                </div>
            </ul>
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
                    <button onClick={this.thisWeek}>This Week</button> &nbsp;
                    <button onClick={this.lastWeek}>Last Week</button> &nbsp;
                    <button onClick={this.thisMonth}>This Month</button> &nbsp;
                    <button onClick={this.lastMonth}>Last Month</button> &nbsp;
                    <button onClick={this.toggleVisilibity}>Advanced</button>
                    {this.state.setStatisticsDateVisibility && (
                        <form>
                            <label>Select starting date:</label><input type="date" name="start" class="form-control" style={{ width: "20%" }}></input>
                            <label>Select ending date:</label><input type="date" name="end" class="form-control" style={{ width: "20%" }}></input>
                            <p></p>
                            <button onClick={this.lastMonth}>Show Stats</button>
                        </form>
                    )}
                    <p></p>
                </div>
                {contents}
            </div>
        );
    }

    toggleVisilibity() {
        this.setState({
            setStatisticsDateVisibility: !this.state.setStatisticsDateVisibility
        });
    }
    }
