import React, { Component } from 'react';

export default class AddGoal extends Component {
    static displayName = AddGoal.name;

    constructor(props) {
        super(props);
        this.state = {
            addNewGoalVisibility: false,
            inputName: "",
            inputDescription: "",
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

    handleAmountChange = (event) => {
        this.setState({ inputAmount: event.target.value });
    }

    handleNameChange = (event) => {
        this.setState({ inputName: event.target.value });
    }

    handleDescriptionChange = (event) => {
        this.setState({ inputDescription: event.value });
    }

    render() {
        return (
            <div>
                <button className="btn btn-primary" onClick={this.toggleVisilibity}>Add Goal</button>
                {this.state.addNewGoalVisibility && (
                    <form onSubmit={this.handleNewTransaction}>{"\n"}
                        <input type="text" placeholder="  Name" onChange={this.handleNameChange} style={{ width: "100%", height: 37 }} />
                        <input type="number" min="0" step="any" placeholder="  Amount" onChange={this.handleAmountChange} style={{ width: "100%", height: 37 }} />
                        <input type="text" placeholder="  Description" onChange={this.handleDescriptionChange} style={{ width: "100%", height: 37 }} />
                        <input type="submit" value="Add" style={{ width: "140px", height: 37 }} />
                    </form>
                )}
            </div>

        );
    }   

    toggleVisilibity = () => {
        this.setState({
            addNewGoalVisibility: !this.state.addNewGoalVisibility
        });
    }
}