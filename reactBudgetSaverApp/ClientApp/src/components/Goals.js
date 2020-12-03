import React, { Component, useState } from 'react';

export class Goals extends Component {
    static displayName = Goals.name;

  constructor(props) {
    super(props);
      this.state = {
          goals: {}, loading: true
      };
      this.getProfitMonthly = this.getProfitMonthly.bind(this);
    }

    async getProfitMonthly() {
        const response = await fetch('goals/GetProfitMonthly');
        const data = await response.json();
        console.log(data);
        this.setState({ goals: data, loading: false });
    }

    static renderGoal(goals) {
        return (
            <ul>
                <p></p>
                <div>
                    <li>Goal name: {goals}</li>
                </div>
            </ul>
        );
    } 

    componentDidMount() {
        this.getProfitMonthly();
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Goals.renderGoal(this.state.goals);
        return (
            <div>
                <h1>Goals</h1>
                {contents}                
            </div>
        );
    }
  }


