import React, { Component } from 'react';

export default class AddGoal extends Component {
    static displayName = AddGoal.name;

    constructor(props) {
        super(props);
        this.state = {
            addNewGoalVisibility: false,
            inputName: "",
            inputDescription: "",
            inputAmount: "",
            editMode: false,
            buttonText: "Add",
            editingId: -1,
            deleteMode: false
        };

    }


    clearAdd = (full) => {
        if (full) {
            this.setState({ inputName: "", inputAmount: "", inputDescription: "", addNewGoalVisibility: false, editMode: false, buttonText: "Add"});
        } else {
            this.setState({ inputName: "", inputAmount: "", inputDescription: "", editMode: false, buttonText: "Add"});
        }
        
    }

    handleUpdateGoal = (goal) => {
        goal["goalId"] = parseInt(this.state.editingId);

        console.log(goal);
        this.clearAdd(true);

        const message = {
            method: 'post',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(goal)
        };

        fetch('Goals/PostUpdateGoal', message)
            .then(response => {
                if (response.ok) {
                    return response.json();
                } else {
                    response.text().then((s) => window.alert(s));//cia reiks fixint kad butu reactinis solutionas
                    return null;
                }
            }).then(data => {
                if (data !== null) {
                    this.props.onUpdate(data,true);
                }
            });

    }

    handleDeleteGoal = async () => {
        console.log(parseInt(this.state.editingId));
        const response = await fetch('Goals/DeleteGoal?id=' + parseInt(this.state.editingId));
        const data = await response;
        this.clearAdd(true);
        this.props.onUpdate(parseInt(this.state.editingId), true);
    }

    handleNewGoal = (event) => {
        // Simple POST request with a JSON body using fetch
        event.preventDefault();

        



        //verification
        if (this.state.inputName === "" || this.state.inputAmount === "" || this.state.inputDescription === "") {
            return;
        }

        var data = { inputName: this.state.inputName, inputAmount: parseFloat(this.state.inputAmount), inputDescription: this.state.inputDescription };

        if (this.state.deleteMode) {


            this.setState({ deleteMode: false });
            this.handleDeleteGoal();
            


        } else if (this.state.editMode) {
            this.handleUpdateGoal(data);
        } else {

            this.clearAdd(true);

            const message = {
                method: 'post',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(data)
            };
        

            fetch('Goals/PostAddGoal', message)
                .then(response => {
                    if (response.ok) {
                        return response.json();
                    } else {
                        response.text().then((s) => window.alert(s));//cia reiks fixint kad butu reactinis solutionas
                        return null;
                    }
                }).then(data => {
                    if (data !== null) {
                        this.props.onUpdate(data,false);
                    }
                });

        }
    }

    changeDeleteMode = (event) => {
        this.setState({ deleteMode: true });
    }

    handleAmountChange = (event) => {
        this.setState({ inputAmount: event.target.value });
    }

    handleNameChange = (event) => {
        this.setState({ inputName: event.target.value });
    }

    handleDescriptionChange = (event) => {
        this.setState({ inputDescription: event.target.value });
    }



    render() {
        return (
            <div>
                <button className="btn btn-primary" onClick={this.toggleVisilibity}>Add Goal</button>
                {this.state.addNewGoalVisibility && (
                    <form onSubmit={this.handleNewGoal}>{"\n"}
                        <input type="text" placeholder="  Name" value={this.state.inputName} onChange={this.handleNameChange} style={{ width: "100%", height: 37 }} />
                        <input type="number" min="0" step="any" placeholder="  Amount" value={this.state.inputAmount} onChange={this.handleAmountChange} style={{ width: "100%", height: 37 }} />
                        <input type="text" placeholder="  Description" value={this.state.inputDescription} onChange={this.handleDescriptionChange} style={{ width: "100%", height: 37 }} />
                        <div style={{ marginTop: 10 }}>
                            <input type="submit" value={this.state.buttonText} style={{ width: "140px", height: 37 }} />
                        </div>
                        {this.state.editMode && (
                            <input className="btn btn-danger" type="submit" value="Delete" onClick={this.changeDeleteMode} style={{ width: "140px", height: 37 }} />
                        )}
                        
                    </form>
                    
                )}
            </div>

        );
    }   

    fillFields = (goal, visibility, id) => {
        if (!visibility) {
            this.setState({
                addNewGoalVisibility: false,
            });
            this.clearAdd(false);
        } else {
            this.setState({
                addNewGoalVisibility: true,
                inputName: goal.goalItemName,
                inputAmount: goal.goalItemPrice,
                inputDescription: goal.goalDescription,
                editMode: true,
                buttonText: "Update",
                editingId: id
            });
        }
        
    }

    toggleVisilibity = () => {
        if (this.state.editMode == false) {
            this.setState({
                addNewGoalVisibility: !this.state.addNewGoalVisibility
            });
        } else {
            this.clearAdd(false);
        }
        
        
    }
}