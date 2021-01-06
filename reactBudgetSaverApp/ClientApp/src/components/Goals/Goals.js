import React, { Component, useState } from 'react';
import AddGoal from './AddGoal.js'


export class Goals extends Component {
    static displayName = Goals.name;

  constructor(props) {
    super(props);
      this.state = {
          loading: true,
          goalValue: [],
          checkboxSavings: false,
          checkboxPossessions: false,
          checkboxInflation: false,
          dailyProfit: [],
          possessions: [],
          statistic: [],
          slider: 50,
          inflation: [],
          disablePossession: false,
          inflationVisibility: false,
      };
      this.GoalValues = this.GoalValues.bind(this);
    }

    async GoalValues() {
        const response = await fetch('goals/GoalValues');
        const data = await response.json();
        console.log(data);
        this.setState({ goalValue: data, dailyProfit: data.item6, loading: false });
    }

    async TotalPossessionsValues() {
        const response = await fetch('goals/PossessionsValues');
        const data = await response.json();
        console.log(data);
        this.setState({ possessions: data, loading: false });
    }
    changeSavingsHandle = event => {
        if (this.state.checkboxSavings)
            this.setState({
                checkboxSavings: event.target.checked,
                dailyProfit: (this.state.dailyProfit - this.state.goalValue.item4)
            })
        else
            this.setState({
                checkboxSavings: event.target.checked,
                dailyProfit: (this.state.dailyProfit + this.state.goalValue.item4)
            })
    }
    changePossessionsHandle = event => {
        if (this.state.checkboxPossessions)
            this.setState({
                checkboxPossessions: event.target.checked,
                inflationVisibility: !this.state.inflationVisibility,
                dailyProfit: (this.state.dailyProfit - this.state.possessions)
            })
        else
            this.setState({
                checkboxPossessions: event.target.checked,
                inflationVisibility: !this.state.inflationVisibility,
                dailyProfit: (this.state.dailyProfit + this.state.possessions)
            })
    }
    changeInflationHandle = event => {
        if (this.state.checkboxInflation)
            this.setState({
                checkboxInflation: event.target.checked,
                disablePossession: false,
                dailyProfit: (this.state.dailyProfit - (this.state.possessions * this.state.inflation / 365))
            })
        else
            this.setState({
                checkboxInflation: event.target.checked,
                disablePossession: true,
                dailyProfit: (this.state.dailyProfit + (this.state.possessions * this.state.inflation / 365))
            })
    }
    sliderChange = event => {
        this.setState({
            slider: event.target.value,
            dailyProfit: (((this.state.statistic.totalIncome - this.state.statistic.totalExpenses) / 30) * (this.state.slider * 100))
        })
    }

    async totalValue() {
        const response = await fetch('possessions/TotalPossessionValue');
        const data = await response.json();
        console.log(data);
        this.setState({ possessions: data, loading: false });
    }

    lastMonth = async () => {
        const response = await fetch('statistic/lastmonth');
        const data = await response.json();
        console.log(data);
        this.setState({ statistic: data, loading: false, dailyProfit: (((data.totalIncome - data.totalExpenses) / 30) * (this.state.slider * 100)) });
    }

    async percentageValue() {
        const response = await fetch('possessions/PossessioninflationValue');
        const data = await response.json();
        console.log(data);
        this.setState({ inflation: data, loading: false });
    }

    static renderGoal(goalValue, dailyProfit) {
        return (
            <ul>
                <AddGoal />
                {goalValue.map((goal, index) =>
                    <div key={index}>
                        <li><b>Days until goal is reached: {Math.round(goal.goalItemPrice / dailyProfit)}</b></li>
                        <li>Goal: {goal.goalItemName}</li>
                        <li>Goal price: {goal.goalItemPrice + ' \u20AC'}</li>
                        <li>Goal description: {goal.goalDescription}</li>
                        <li>Monthly salary: 0</li>
                        <li>Total savings: 0</li>
                        <p></p>
                    </div>
                    
                )}
            </ul>
        );
    } 

    onUpdate(data) {
        //console.log("Labas");
    }

    componentDidMount() {
        this.GoalValues();
        this.lastMonth();
        this.totalValue();
        this.percentageValue();
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Goals.renderGoal(this.state.goalValue, this.state.dailyProfit);
        return (
            <div>
                <h1>Goals</h1>
                <label> Percentage from profits: </label>
                <p> Selected value: {this.state.slider} %</p>
                <p><input type="range" value={this.state.slider} onChange={this.sliderChange} min="0" style={{ width: "50%" }} /></p>
                <label> Will use savings: </label><input type="checkbox" checked={this.state.checkboxSavings} onChange={this.changeSavingsHandle} style={{ marginLeft: "10px", marginRight: "10px" }} />
                <label> Will use possessions: </label><input type="checkbox" disabled={this.state.disablePossession} checked={this.state.checkboxPossessions} onChange={this.changePossessionsHandle} style={{ marginLeft: "10px", marginRight: "10px" }} />
                {this.state.inflationVisibility && (
                    <label>
                        <label> Apply inflation to possessions: </label><input type="checkbox" checked={this.state.checkboxInflation} onChange={this.changeInflationHandle} style={{ marginLeft: "10px", marginRight: "10px" }} />
                    </label>
                )}
                {contents}               
            </div>
        );
    }
  }


