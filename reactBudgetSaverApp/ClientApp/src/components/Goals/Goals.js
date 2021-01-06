import React, { Component, useState } from 'react';
import AddGoal from './AddGoal.js'


export class Goals extends Component {
    static displayName = Goals.name;

  constructor(props) {
    super(props);
      this.state = {
          loading: true,
          goalValue: []
      };
      this.GoalValues = this.GoalValues.bind(this);
    }

    async GoalValues() {
        const response = await fetch('goals/GoalValues');
        const data = await response.json();
        console.log(data);
        this.setState({ goalValue: data, loading: false });
    }

    static renderGoal(goalValue) {
        return (
            <ul>
                <AddGoal />
                {goalValue.map((goal, index) =>
                    <div key={index}>
                        <li>Goal: {goal.goalItemName}</li>
                        <li>Goal price: {goal.goalItemPrice}</li>
                        <li>Goal description: {goal.goalDescription}</li>
                        <li>Days until goal is reached: 0</li>
                        <li>Monthly salary: 0</li>
                        <li>Total savings: 0</li>
                        <p></p>
                    </div>
                    
                )}
            </ul>
        );
    } 

    onUpdate(data) {
        console.log("Labas");
    }

    componentDidMount() {
        this.GoalValues();
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Goals.renderGoal(this.state.goalValue);
        return (
            <div>
                <h1>Goals</h1>
                {contents}                
            </div>
        );
    }
  }


