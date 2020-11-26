import React, { Component, useState } from 'react';

export class Goals extends Component {
    static displayName = Goals.name;

  constructor(props) {
    super(props);
      this.state = {
          goals: {}, loading: true
      };
      this.thisWeek = this.thisWeek.bind(this);
    }

    async thisWeek() {
        const response = await fetch('goals/thisweek');
        const data = await response.json();
        console.log(data);
        this.setState({ goals: data, loading: false });
    }

    static renderGoal(goals) {
        return (
            <ul>
                <p></p>
                <div>
                    <li>Goal name: {goals.thisWeek }</li>
                </div>
            </ul>
        );
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


