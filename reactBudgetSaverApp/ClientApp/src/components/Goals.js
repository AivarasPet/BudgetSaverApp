import React, { Component, useState } from 'react';

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
                <p></p>
                <div>
                    <li>Main goal: {goalValue.item1}</li>
                    <li>Main goal price: {goalValue.item2}</li>
                    <li>Days until goal is reached: {goalValue.item5}</li>
                    <li>Monthly salary: {goalValue.item3}</li>
                    <li>Total savings: {goalValue.item4}</li>
                </div>
            </ul>
        );
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


