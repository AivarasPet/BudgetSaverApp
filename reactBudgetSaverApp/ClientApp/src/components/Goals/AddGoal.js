import React, { Component } from 'react';

export default class AddGoal extends Component {
    static displayName = AddGoal.name;

    constructor(props) {
        super(props);
        this.state = {
            addNewGoalVisibility: false,
            inputType: "",
            inputCategory: "",
            inputTitle: "",
            inputAmount: NaN
        };

    }

    toggleVisilibity = () => {
        this.setState({
            addNewGoalVisibility: !this.state.addNewGoalVisibility
        });
    }
}