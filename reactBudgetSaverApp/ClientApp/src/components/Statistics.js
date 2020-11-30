import React, { Component } from 'react';
import "./Statistics.css"

export class Statistics extends Component {
    static displayName = Statistics.name;

  constructor(props) {
    super(props);
      this.state = {
          currentCount: 0,
          statistic: {},
          loading: true,
          setStatisticsDateVisibility: false,
          subStatistics: {}
      };

      this.renderStatistic = this.renderStatistic.bind(this);
      this.renderSubStatistics = this.renderSubStatistics.bind(this);

      this.startDate = React.createRef();
      this.endDate = React.createRef();
  }

    thisWeek = async () => {
        const response = await fetch('statistic/thisweek');
        const data = await response.json();
        this.setState({ statistic: data, subStatistics: data.subStatsMap, loading: false });
    }

    lastWeek = async () => {
        const response = await fetch('statistic/lastweek');
        const data = await response.json();
        this.setState({ statistic: data, subStatistics: data.subStatsMap, loading: false });
    }

    thisMonth = async () => {
        const response = await fetch('statistic/thismonth');
        const data = await response.json();
        this.setState({ statistic: data, subStatistics: data.subStatsMap, loading: false });
    }

    lastMonth = async () => {
        const response = await fetch('statistic/lastmonth');
        const data = await response.json();
        console.log(data);
        this.setState({ statistic: data, subStatistics: data.subStatsMap, loading: false });
    }

    advanced = async (event) => {
        event.preventDefault();
        var url = new URL(window.location.origin+'/statistic/advanced');
        url.searchParams.append("startDate", this.startDate.current.value);
        url.searchParams.append("endDate", this.endDate.current.value);
        const response = await fetch(url);
        const data = await response.json();
        this.setState({ statistic: data, subStatistics: data.subStatsMap, loading: false });
    }


    renderSubStatistics(subStatistics) {
        return (
            <table className='table table-bordered table-sm table-hover table-striped' aria-labelledby="tabelLabel" sortable="true">
                <thead className="thead-dark">
                    <tr>
                        <th data-field="id" >Category</th>
                        <th>Amount </th>
                        <th>Income</th>
                        <th>Expenses</th>
                    </tr>
                </thead>
                <tbody>
                    {Object.keys(subStatistics).map((key, index) => 
                        <tr key={index}>
                            <td>{key}</td>
                            <td>{subStatistics[key].count}</td>
                            <td>{subStatistics[key].income}</td>
                            <td>{subStatistics[key].expenses}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }


    renderStatistic(statistics) {
        let contents = this.renderSubStatistics(this.state.subStatistics);
        return (
            <ul>
                <p></p>
                <div>
                    <li>Transaction amount: {statistics.transactionAmount}</li>
                    <li>Income: + {statistics.totalIncome} {'\u20AC'}</li>
                    <li>Expenses: - {statistics.totalExpenses} {'\u20AC'}</li>
                    <li>Balance: {statistics.totalIncome - statistics.totalExpenses} {'\u20AC'}</li>
                </div>
                <p></p>
                {contents}
                
            </ul>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderStatistic(this.state.statistic);
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
                        <form onSubmit={this.advanced}>
                            <label >Select starting date:</label><input type="date"  className="form-control" ref={this.startDate}></input>
                            <label >Select ending date:</label><input type="date" className="form-control" ref={this.endDate}></input>
                            <p></p>
                            <input type="submit" value="Show Stats" style={{ width: "140px", height: 37 }}/>
                        </form>
                    )}
                    <p></p>
                </div>
                {contents}
            </div>
        );
    }

    toggleVisilibity = () => {
        this.setState({
            setStatisticsDateVisibility: !this.state.setStatisticsDateVisibility
        });
    }
}
