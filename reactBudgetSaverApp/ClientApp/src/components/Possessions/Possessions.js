import React, { Children, Component } from 'react';
import './Possessions.css';
import Modal from '../Modal.js';
import * as AuthService from '../UserAuthentication/AuthService' 

const requestOptions = {
    method: 'GET',
    headers: { 'Content-Type': 'application/json', 'Authorization': 'Bearer ' + AuthService.getToken() },
};

export class Possessions extends Component {
    static displayName = Possessions.name;

    constructor(props) {
        super(props);
        this.state = { possessions: [], loading: true, doShowUpdateModal: false, doShowDeleteModal: false, doShowInsertModal: false, possessionNamesinSelect: [], possessionNames: [], ownedPossessionNames: [] };
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
        this.populatePossessionNames();
        this.populateOwnedPossessionNames();
    }


    showInsertModal = () => {
        let varia = this.state.possessionNames;
        this.setState({ doShowInsertModal: true, possessionNamesinSelect: varia });
    };
    showUpdateModal = () => {
        let varia = this.state.ownedPossessionNames;
        this.setState({ doShowUpdateModal: true, possessionNamesinSelect: varia  });
    };
    showDeleteModal = () => {
        let varia = this.state.ownedPossessionNames;
        this.setState({ doShowDeleteModal: true, possessionNamesinSelect: varia });
    };

    hideModals = () => {
        this.setState({ doShowInsertModal: false });
        this.setState({ doShowDeleteModal: false });
        this.setState({ doShowUpdateModal: false });
    };


    updatePossession = (PossessionName, amount) => {
        if (PossessionName === NaN || amount === NaN) {
            return;
        }
        this.hideModals();

        var data = { PossessionName: PossessionName, Amount: parseFloat(amount) };
        console.log("Data: "+data.PossessionId);
        const message = {
            method: 'post',
            headers: { 'Content-Type': 'application/json',  'Authorization': 'Bearer ' + AuthService.getToken()},
            body: JSON.stringify(data)
        };


        fetch('possession/PostUpdatePossession', message)
            .then(response => {
                if (response.ok) {
                    return response.json();
                } else {
                    response.text().then((s) => window.alert(s));//cia reiks fixint kad butu reactinis solutionas
                    return null;
                }
            }).then(data => {
                if (data !== null) {
                   this.setState({possessions: data});
                }
                });
        
    }
    insertPossession = (PossessionName, amount) => {
        

        if (PossessionName === NaN || amount === 0) {
            return;
        }
        this.hideModals();


        var data = { PossessionName: PossessionName, Amount: parseFloat(amount) };


        console.log(data);

        const message = {
            method: 'post',
            headers: { 'Content-Type': 'application/json',  'Authorization': 'Bearer ' + AuthService.getToken()},
            body: JSON.stringify(data)
        };


        fetch('possession/PostAddPossession', message)
        .then(response => {
          if (response.ok) {
              return response.json();
          } else {
              response.text().then((s) => window.alert(s));//cia reiks fixint kad butu reactinis solutionas
              return null;
          }
        }).then(data => {
          if (data !== null) {
            this.setState({possessions: data});
            this.populateOwnedPossessionNames();
          }
          });


    }
    deletePossession = async(PossessionName, empty) => { //ID ateina

        if (PossessionName === NaN) {
            return;
        }
        this.hideModals();

        const response = await fetch('possession/DeletePossession?possessionName=' + PossessionName, requestOptions);
        const data = await response.json();
        this.setState({ possessions: data });
        this.populateOwnedPossessionNames();
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
                        <th>Change %</th>
                    </tr>
                </thead>
                <tbody>
                    {possessions.map((possession, index) =>
                        <tr key={index}>
                            <td><img src={possession.urlImage} className="image" /></td>
                            <td>{possession.name}</td>
                            <td>{possession.amount}</td>
                            <td>{Math.round(possession.valueInDollars*possession.amount * 100)/100}</td>
                            <td>{Math.round(possession.percentageChangeInValue*100)/100} %</td>
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
                    actionName = "Insert"
                    handleAction = {this.insertPossession}
                    selectArray = {this.state.possessionNamesinSelect}
                    inputField = {true}
                >
                </Modal>
                <Modal show = {this.state.doShowUpdateModal}
                    handleClose = {this.hideModals}
                    actionName = "Update"
                    handleAction = {this.updatePossession}
                    selectArray = {this.state.possessionNamesinSelect}
                    inputField = {true}
                >
                </Modal>
                <Modal show = {this.state.doShowDeleteModal}
                    handleClose = {this.hideModals}
                    actionName = "Delete"
                    handleAction = {this.deletePossession}
                    selectArray = {this.state.possessionNamesinSelect}
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

    async populatePossessionNames() {
        const response = await fetch('possession/names', requestOptions);
        const data = await response.json();
        console.log(data);

        var tempCategories = [];
        data.forEach(function (element) {
            tempCategories.push({ label: element, value: element })
        });

        this.setState({possessionNames: tempCategories });
    }

    async populateOwnedPossessionNames() {
        const response = await fetch('possession/OwnedPossessionNames', requestOptions);
        const data = await response.json();
        console.log(data);

        var tempCategories = [];
        data.forEach(function (element) {
            tempCategories.push({ label: element, value: element })
        });

        this.setState({ownedPossessionNames: tempCategories });
    }

    async populatePossessionData() {
        const response = await fetch('possession', requestOptions);
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