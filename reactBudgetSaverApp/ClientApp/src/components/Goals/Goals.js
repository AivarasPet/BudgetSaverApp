import React, { Component, useState } from 'react';
import AddGoal from './AddGoal.js';
import './Goals.css';


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
          possessionInflated: [],
          disablePossession: false,
          inflationVisibility: false,
          savings: 0,
          openedGoal: -1
      };

      this.editMode = React.createRef();
    }

    componentDidMount() {
        this.goalValues();
        this.userData();
        this.lastMonth();
        this.totalValue();
        this.percentageValue();
    }

    async userData() {
        const response = await fetch('goals/UserData');
        const data = await response.json();
        console.log(data);
        this.setState({savings: data});
    }
    
    async goalValues() {
        const response = await fetch('goals/GoalValues');
        const data = await response.json();
        console.log(data);
        this.setState({ goalValue: data, loading: false });
    }

    async TotalPossessionsValues() {
        const response = await fetch('goals/PossessionsValues');
        const data = await response.json();
        console.log(data);
        this.setState({ possessions: data, loading: false });
    }

    changeSavingsHandle = event => {
        this.setState({ checkboxSavings: event.target.checked });
    }

    changePossessionsHandle = event => {
        this.setState({ checkboxPossessions: event.target.checked, inflationVisibility: !this.state.inflationVisibility });
    }

    changeInflationHandle = event => {
        this.setState({checkboxInflation: event.target.checked, disablePossession: !this.state.checkboxInflation});
    }

    sliderChange = event => {
        this.setState({ slider: event.target.value });
        this.setState({ dailyProfit: (((this.state.statistic.totalIncome - this.state.statistic.totalExpenses) / 30) * (event.target.value / 100)) });
    }

    async totalValue() {
        const response = await fetch('possession/TotalPossessionValue');
        const data = await response.json();
        console.log(data);
        this.setState({ possessions: data, loading: false });
    }

    lastMonth = async () => {
        const response = await fetch('statistic/lastmonth');
        const data = await response.json();
        console.log(data);
        this.setState({ statistic: data, loading: false, dailyProfit: (((data.totalIncome - data.totalExpenses) / 30) * (this.state.slider / 100)) });
    }

    async percentageValue() {
        const response = await fetch('possession/PossessionInflationValue');
        const data = await response.json();
        console.log(data);
        this.setState({ possessionInflated: data, loading: false });
    }

    goalChangeWindow = (event) => {
        var id = event.currentTarget.attributes.id.value;
        if (id == this.state.openedGoal) {
            this.setState({ openedGoal: -1 });
            this.editMode.current.fillFields(this.state.goalValue[id], false, -1);
        } else if (this.state.openedGoal !== -1) {
            this.editMode.current.fillFields(this.state.goalValue[id], true, id);
            this.setState({ openedGoal: id });
        } else {
            this.editMode.current.fillFields(this.state.goalValue[id], true, id);
            this.setState({ openedGoal: id });
        }
    }


    renderGoal(goalValue, dailyProfit, savings, possessions) {
        return (
            <ul>
                {goalValue.map((goal, index) =>
                    <div key={index} className="goalDiv" id={index} onClick={this.goalChangeWindow}>
                        <li><b>Days until goal is reached: {Math.round((goal.goalItemPrice - savings - possessions) / dailyProfit)}</b></li>
                        <li>Goal: {goal.goalItemName}</li>
                        <li>Goal price: {goal.goalItemPrice}</li>
                        <li>Goal description: {goal.goalDescription}</li>
                        <p></p>
                    </div>
                )}
            </ul>
        );
    } 

    onUpdate(data, update) {
        var goals = this.state.goalValue;
        if (update) {
            console.log(data);
            if (typeof data == "number") {
                goals.splice(data, 1);
                
            } else {
                var temp = { goalItemName: data.inputName, goalItemPrice: data.inputAmount, goalDescription: data.inputDescription };
                console.log(temp);
                goals[data.goalId] = temp;
                console.log(goals);
            }
            this.setState({ goalValue: goals });
            
            
        } else {
            goals.push(data);
            this.setState({ goalValue: goals });
        }
        this.setState({ openedGoal: -1 });
        
    }

    render() {
        let savings = this.state.checkboxSavings
            ? this.state.savings
            : 0;

        let possessions = this.state.checkboxPossessions
            ? this.state.possessions
            : 0;
        
        possessions = this.state.checkboxInflation
            ? this.state.possessionInflated
            : possessions;

        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderGoal(this.state.goalValue, this.state.dailyProfit, savings, possessions);
        return (
            <div>
                <h1>Goals</h1>
                <p>Current savings: {this.state.savings}</p>
                <label> Percentage from profits: </label>
                <p> Selected value: {this.state.slider} %</p>
                <p><input type="range" onChange={this.sliderChange} min="0" style={{ width: "50%" }} /></p>
                <label> Will use savings: </label><input type="checkbox" checked={this.state.checkboxSavings} onChange={this.changeSavingsHandle} style={{ marginLeft: "10px", marginRight: "10px" }} />
                <label> Will use possessions: </label><input type="checkbox" disabled={this.state.disablePossession} checked={this.state.checkboxPossessions} onChange={this.changePossessionsHandle} style={{ marginLeft: "10px", marginRight: "10px" }} />
                {this.state.inflationVisibility && (
                    <label>
                        <label> Apply inflation to possessions: </label><input type="checkbox" checked={this.state.checkboxInflation} onChange={this.changeInflationHandle} style={{ marginLeft: "10px", marginRight: "10px" }} />
                    </label>
                )}
                {contents}
                <AddGoal ref={this.editMode} onUpdate={this.onUpdate.bind(this)}/>
            </div>
        );
    }

  }


