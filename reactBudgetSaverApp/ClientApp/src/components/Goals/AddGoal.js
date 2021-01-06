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

    handleNewGoal = (event) => {
        // Simple POST request with a JSON body using fetch
        event.preventDefault();

        //verification
        /*if (this.state.inputType === "" || this.state.inputAmount === NaN || this.state.inputTitle === "" || this.state.inputCategory === "") {
            return;
        }

        var data = { transactType: this.state.inputType, amount: parseFloat(this.state.inputAmount), title: this.state.inputTitle, category: this.state.inputCategory };


        console.log(data);

        this.clearAdd();

        const message = {
            method: 'post',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
        };
        

        fetch('Transaction/PostAddTransaction', message)
            .then(response => {
                if (response.ok) {
                    return response.json();
                } else {
                    response.text().then((s) => window.alert(s));//cia reiks fixint kad butu reactinis solutionas
                    return null;
                }
            }).then(data => {
                if (data !== null) {
                    this.props.onUpdate(data);
                }

            });

*/
    }

    render() {
        return (
            <div>

                Labas
            </div>

        );

    }  

    toggleVisilibity = () => {
        this.setState({
            addNewGoalVisibility: !this.state.addNewGoalVisibility
        });
    }
}