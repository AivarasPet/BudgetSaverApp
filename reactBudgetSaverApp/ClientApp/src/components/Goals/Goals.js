import React, { Component, useState } from 'react';
import AddGoal from './AddGoal.js';
import './Goals.css';
import MoneyField from './../UIElements/MoneyField'
import * as AuthService from './../UserAuthentication/AuthService' 
import { event } from 'jquery';

const requestOptions = {
    method: 'GET',
    headers: { 'Content-Type': 'application/json', 'Authorization': 'Bearer ' + AuthService.getToken() },
};

export class Goals extends Component {
    static displayName = Goals.name;

  constructor(props) {
      super(props);

      this.state = {
          loading: true,
          goalValue: [],
          checkboxSavings: false,
          checkboxPossessions: false,
          checkboxAppreciation: false,
          dailyProfit: [],
          possessionsVal: 0,
          profitFromStats : 0,
          slider: 50,
          possessionInflated: [],
          disablePossession: false,
          appreciationVisibility: false,
          savings: 0,
          possessionAppreciation: 0,
          openedGoal: -1,
          daysList: []
      };

      this.editMode = React.createRef();
    }


    getPossessionCost = function () {
        var sum = 0;
        for(let x = 0; x < this.state.possessions.length; x++) {
            sum += this.state.possessions[x].amount * this.state.possessions[x].valueInDollars;
        }
        return sum;
    }

    updateDays = (dailyProfit) => {
        let list = this.state.daysList;
        let sav = this.state.checkboxSavings ? this.state.savings : 0;
        let pos = this.state.checkboxPossessions ? this.state.possessionsVal : 0;
        for(let y = 0; y < this.state.goalValue.length; y++) {
            //console.log("goalo price " + this.state.goalValue[y].inputAmount );
            if(this.state.checkboxAppreciation == false) list[y] =  Math.round((this.state.goalValue[y].goalItemPrice - sav - pos) / dailyProfit);
            else {
                for(let x = 0; x < 100000; x++) {
                    if(this.state.goalValue[y].goalItemPrice - sav < x * dailyProfit +  pos * Math.pow((1+(this.state.possessionAppreciation/100)), x/365)) {list[y] = x; break;} 
                }
            }
        }
        this.setState({daysList:list});
    }

    updateDaysPerc = (appreciation) => {
        let list = this.state.daysList;
        let sav = this.state.checkboxSavings ? this.state.savings : 0;
        let pos = this.state.checkboxPossessions ? this.state.possessionsVal : 0;
        for(let y = 0; y < this.state.goalValue.length; y++) {
            for(let x = 0; x < 100000; x++) {
                if(this.state.goalValue[y].goalItemPrice - sav < x * this.state.dailyProfit +  pos * Math.pow((1+(appreciation/100)), x/365)) {list[y] = x; break;} 
            }
        }
        this.setState({possessionAppreciation: appreciation, daysList:list});
    }



    componentDidMount() {
        this.getProfit();
        this.goalValues();
        this.userData();
        this.totalPossessionValue();
        this.percentageValue();
    }

    async userData() {
        const response = await fetch('goals/UserData', requestOptions);
        const data = await response.json();
        console.log(data);
        this.setState({savings: data});
    }
    
    async goalValues() {
        const response = await fetch('goals/GoalValues', requestOptions);
        const data = await response.json();
        console.log(data);
        this.setState({ goalValue: data, loading: false });
    }


    changeSavingsHandle = event => {
        this.setState({ checkboxSavings: event.target.checked });
        this.updateDays(this.state.dailyProfit);
    }

    changePossessionsHandle = event => {
        this.setState({ checkboxPossessions: event.target.checked, appreciationVisibility: !this.state.appreciationVisibility });
        this.updateDays(this.state.dailyProfit);
    }

    changeAppreciationHandle = event => {
        this.setState({checkboxAppreciation: event.target.checked, disablePossession: !this.state.checkboxAppreciation});
        this.updateDays(this.state.dailyProfit);
    }

    sliderChange = event => {
        this.setState({ slider: event.target.value });
        this.setState({ dailyProfit: Math.round((this.state.profitFromStats * (event.target.value / 100))*100)/100  });
        this.updateDays(this.state.profitFromStats * (event.target.value / 100));
        //console.log("days: " + list + " " + this.state.savings + " n " + this.state.possessions);
    }



    async totalPossessionValue() {
        const response = await fetch('possession/TotalPossessionValue', requestOptions);
        const data = await response.json();
        console.log("sviezia:" + data);
        this.setState({ possessionsVal: data, loading: false });
    }
    
    getProfit = async () => {
        const response = await fetch('statistic/GetProfit', requestOptions);
        const data = await response.json();
        this.setState({ profitFromStats: data, dailyProfit: (this.state.profitFromStats * (this.state.slider / 100)) });
        console.log("profit from " + this.state.profitFromStats);
    }

    async percentageValue() {
        const response = await fetch('possession/PossessionInflationValue', requestOptions);
        const data = await response.json();
        console.log(data);
        this.setState({ possessionInflated: data, loading: false });
    }

    expandGoalEditWindow = (event) => {
        var tileNr = event.currentTarget.attributes.id.value;
        if (tileNr == this.state.openedGoal) {
            this.setState({ openedGoal: -1 });
            this.editMode.current.fillFields(this.state.goalValue[tileNr], false, -1);
        } else if (this.state.openedGoal !== -1) {
            this.editMode.current.fillFields(this.state.goalValue[tileNr], true, tileNr);
            this.setState({ openedGoal: tileNr });
        } else {
            this.editMode.current.fillFields(this.state.goalValue[tileNr], true, tileNr);
            this.setState({ openedGoal: tileNr });
        }
    }





    popupContent = function() {
        return (
            <h1>ss</h1> 
        )
      }

    renderGoal(goalValue, dailyProfit, savings, possessions) {
            
        return (
            <ul>
                {goalValue.map((goal, index) =>
                    <div key={index} className="goalDiv" id={index} onClick={this.expandGoalEditWindow}> 
                        <li><b>Days until goal is reached: {this.state.daysList[index]}</b></li>  
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
        console.log(this.state.dailyProfit + " <- Daily profit");
        var goals = this.state.goalValue;
        if (update) {
            console.log(data);
            if (typeof data == "number") {
                goals.splice(data, 1);
                
            } else {
                var temp = { id: data.id, goalItemName: data.inputName, goalItemPrice: data.inputAmount, goalDescription: data.inputDescription };
                console.log(temp);
                goals[this.state.openedGoal] = temp;
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
        
        possessions = this.state.checkboxAppreciation
            ? this.state.possessionInflated
            : possessions;

        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderGoal(this.state.goalValue, this.state.dailyProfit, savings, possessions);
            
        let savingsField = this.state.checkboxSavings 
            ? <MoneyField  style={{width:"50%"}} label = "Savings" symbol = "€" labelWidth = {60} returnInput={(value) => {this.setState({savings: value}); this.updateDays(this.state.dailyProfit);}}></MoneyField>
            : <div></div>

        let assetAppreciationField = this.state.checkboxAppreciation 
            ?  <MoneyField style={{width:"50%"}} label = "Yearly appreciation" symbol = "%" labelWidth = {135} returnInput={(value) => {this.updateDaysPerc(value);}}></MoneyField>
            : <div></div>


        return (
            <div>
                <h1>Goals</h1>
                <label> Will use savings: </label><input type="checkbox" checked={this.state.checkboxSavings} onChange={this.changeSavingsHandle} style={{ marginLeft: "10px", marginRight: "10px" }} />
                <label> Will use possessions: </label><input type="checkbox" disabled={this.state.disablePossession} checked={this.state.checkboxPossessions} onChange={this.changePossessionsHandle} style={{ marginLeft: "10px", marginRight: "10px" }} />
                {this.state.appreciationVisibility && (
                    <label>
                        <label> Apply appreciation to possessions: </label><input type="checkbox" checked={this.state.checkboxAppreciation} onChange={this.changeAppreciationHandle} style={{ marginLeft: "10px", marginRight: "10px" }} />
                    </label>
                )}
                {savingsField}
                {assetAppreciationField}
                {this.state.checkboxPossessions && (
                    <p>Possessions: {this.state.possessionsVal}</p>
                )}
                <p> Daily profit: {this.state.dailyProfit}</p>
                <p> Percentage from profits: {this.state.slider} %</p>
                <p><input type="range" onChange={this.sliderChange} min="0" style={{ width: "50%" }} /></p>
                {contents}
                <AddGoal ref={this.editMode} onUpdate={this.onUpdate.bind(this)}/>
            </div>
        );
    }

  }

    
  export default function GetDaysLeft({goalValue, Profit, sav, pos}) {
  
    let daysLeft = <div><p>LXOAS</p></div>;

    // if(this.state.checkboxAppreciation && this.state.checkboxPossessions) daysLeft =  Math.round((goalValue - sav - pos) / Profit);
    // else {
    //     for(let x = 0; x < 10000; x++) {
    //         if(goalValue - sav < x * Profit +  pos * (1+this.state.possessionAppreciation/100)^(x/365)) {daysLeft = x;}
    //     }
    // }

    return (
      {daysLeft} 
    );
  }

