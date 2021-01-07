import React, { Children, Component } from 'react';
import './Possessions.css';
import Modal from './Modal.js';

export class Possessions extends Component {
    static displayName = Possessions.name;

    constructor(props) {
        super(props);
        this.state = { possessions: [], loading: true, doShowUpdateModal: false, doShowDeleteModal: false, doShowInsertModal: false, possessionNames: [] };
        this.showInsertModal = this.showInsertModal.bind(this);
        this.showUpdateModal = this.showUpdateModal.bind(this);
        this.showDeleteModal = this.showDeleteModal.bind(this);
        this.hideModals = this.hideModals.bind(this);

        this.editState = {
            selectedPossession: 0
        }
    }

    componentDidMount() {
        this.populatePossessionData();
    }


    showInsertModal = () => {
        this.setState({ doShowInsertModal: true });
    };
    showUpdateModal = () => {
        this.setState({ doShowUpdateModal: true });
    };
    showDeleteModal = () => {
        this.setState({ doShowDeleteModal: true });
    };

    hideModals = () => {
        this.setState({ doShowInsertModal: false });
        this.setState({ doShowDeleteModal: false });
        this.setState({ doShowUpdateModal: false });
    };


    updatePossession = (possessionNumber, newAmount) => {
        console.log(possessionNumber + ' ' + newAmount);
    }
    insertPossession = (possessionNumber, amount) => {
        //console.log(possessionNumber + ' ' + newAmount);
    }
    deletePossession = (possessionNumber) => { //name ateina
        //this.editState({ selectedPossession: event.value });
    }


    static renderPossessionsTable(possessions) {
        return (
            <table className='table table-bordered table-sm table-hover table-striped' aria-labelledby="tableLabel">
                <thead className="thead-dark">
                    <tr>
                        <th style={{ width: '4%' }}>Logo</th>
                        <th>Title</th>
                        <th>Amount</th>
                        <th>Value {'\u0024'}</th>
                    </tr>
                </thead>
                <tbody>
                    {possessions.map((possession, index) =>
                        <tr key={index}>
                            <td><img src={possession.imageUrl} className="image" /></td>
                            <td>{possession.name}</td>
                            <td>{possession.amount}</td>
                            <td>{possession.valueInDollarsWhenBought}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Possessions.renderPossessionsTable(this.state.possessions);

        return (
            <main>
                <h1 id="tableLabel" >Possesion list</h1>
                <Modal show = {this.state.doShowInsertModal}
                    handleClose = {this.hideModals}
                    actionName = "Edit"
                    handleAction = {this.insertPossession}
                    selectArray = {this.state.possessionNames}
                    inputField = {true}
                >
                </Modal>
                <Modal show = {this.state.doShowUpdateModal}
                    handleClose = {this.hideModals}
                    actionName = "Update"
                    handleAction = {this.updatePossession}
                    selectArray = {this.state.possessionNames}
                    inputField = {true}
                >
                </Modal>
                <Modal show = {this.state.doShowDeleteModal}
                    handleClose = {this.hideModals}
                    actionName = "Delete"
                    handleAction = {this.deletePossession}
                    selectArray = {this.state.possessionNames}
                    inputField = {false}
                >
                </Modal>
                <button type="button" onClick={this.showInsertModal}>Insert</button>
                <button type="button" onClick={this.showUpdateModal} style={{ marginLeft: 10 }}>Update</button>
                <button type="button" onClick={this.showDeleteModal} style={{ marginLeft: 10 }}>Delete</button>
                <div>               
                    <p>This table shows total list of all possessions.</p>
                    {contents}
                </div>
            </main>
        );
    }

    async populatePossessionData() {
        const response = await fetch('possession');
        const data = await response.json();
        console.log(data);

        var tempCategories = [];
        data.forEach(function (element) {
            tempCategories.push({ label: element.name, value: element.name })
        });
        console.log(tempCategories)

        this.setState({ possessions: data, loading: false, possessionNames: tempCategories });
    }
}










