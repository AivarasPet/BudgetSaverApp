import React, { Component } from 'react';
import "./Statistics.css"
import Feedback from "./Feedback.js"


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
      this.thisWeek();
      this.renderStatistic = this.renderStatistic.bind(this);
      this.renderSubStatistics = this.renderSubStatistics.bind(this);

      this.startDate = React.createRef();
      this.endDate = React.createRef();
  }

    thisWeek = async () => {
        const response = await fetch('statistic/thisweek');
        const data = await response.json();
        this.setState({ statistic: data, subStatistics: data.subStatsList, loading: false });
    }

    lastWeek = async () => {
        const response = await fetch('statistic/lastweek');
        const data = await response.json();
        this.setState({ statistic: data, subStatistics: data.subStatsList, loading: false });
    }

    thisMonth = async () => {
        const response = await fetch('statistic/thismonth');
        const data = await response.json();
        this.setState({ statistic: data, subStatistics: data.subStatsList, loading: false });
    }

    lastMonth = async () => {
        const response = await fetch('statistic/lastmonth');
        const data = await response.json();
        console.log(data);
        this.setState({ statistic: data, subStatistics: data.subStatsList, loading: false });
    }

    advanced = async (event) => {
        event.preventDefault();
        var url = new URL(window.location.origin+'/statistic/advanced');
        url.searchParams.append("startDate", this.startDate.current.value);
        url.searchParams.append("endDate", this.endDate.current.value);
        const response = await fetch(url);
        const data = await response.json();
        this.setState({ statistic: data, subStatistics: data.subStatsList, loading: false });
    }


    renderSubStatistics(subStatistics) {
        return (
            <table className='table table-bordered table-sm table-hover table-striped statisticsTable' aria-labelledby="tabelLabel" sortable="true">
                <thead className="thead-dark">
                    <tr>
                        <th data-field="id">Category</th>
                        <th>Amount</th>
                    </tr>
                </thead> 
                <tbody>
                    {subStatistics.map((SubStat, index) => 
                        <tr key={index} typeforcss={ SubStat.isIncome ? 0 : 1}>
                            <td>{SubStat.category}</td>
                            {SubStat.isIncome ? <td>{'+ ' + SubStat.amount + ' \u20AC'}</td> : <td>{'- ' + SubStat.amount + ' \u20AC'}</td>}
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
                    {statistics.totalIncome > 0 ? <li>{"Income: " + '+ ' + statistics.totalIncome + ' \u20AC'}</li> : <li>{"Income: " + statistics.totalIncome + ' \u20AC'}</li>}
                    {statistics.totalExpenses > 0 ? <li>{"Expenses: " + '- ' + statistics.totalExpenses + ' \u20AC'}</li> : <li>{"Expenses: " + statistics.totalExpenses + ' \u20AC'}</li>}
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
                            <label >Select starting date:</label><input type="date" className="form-control" ref={this.startDate} style={{ width: "20%", marginTop: "0px", marginBottom: "10px" }}></input>
                            <label >Select ending date:</label><input type="date" className="form-control" ref={this.endDate} style={{ width: "20%", marginTop: "0px"}}></input>
                            <p></p>
                            <input type="submit" value="Show Stats" style={{ width: "140px", height: 37 }}/>
                        </form>
                    )}
                    <p></p>
                </div>
                {contents}
                <h1>Feedback</h1>
                <Feedback />
            </div>
        );
    }

    toggleVisilibity = () => {
        this.setState({
            setStatisticsDateVisibility: !this.state.setStatisticsDateVisibility
        });
    }
}
