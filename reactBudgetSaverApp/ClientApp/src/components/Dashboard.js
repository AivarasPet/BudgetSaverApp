import React, { Children, Component } from "react";
import Modal from './Modal.js';
import Select from 'react-select';

class Dashboard extends Component {
  constructor() {
    super();
    this.state = {
      show: false
    };
    this.showModal = this.showModal.bind(this);
    this.hideModal = this.hideModal.bind(this);

    this.editState = {
      selectedPossession : 0
    }

    this.possessions = [];
    this.populateFieldWithPossessions();
  }
  componentDidMount() {

  }

  showModal = () => {
    this.setState({ show: true });
  };

  hideModal = () => {
    this.setState({ show: false });
  };


  editPossessionCount = (possessionNumber, newAmount) => {
    console.log(possessionNumber + ' ' + newAmount);
  }

  
  handleEditChange = (event) => {
    this.editState({ selectedPossession: event.value });
  } 

  populateFieldWithPossessions = async () => {
  //const response = await fetch('categories/getcategories');
  //const data = await response.json();
  //console.log(data);
  
  var data = ["Bitcoin", "Ethereum"];
  var tempCategories = [];
  data.forEach(function (element) {
      tempCategories.push({ label: element, value: element })
  });

  this.possessions = tempCategories;
  console.log(this.possessions);
}

  render() {
    return (
      <main>
        <h1>React Modal</h1>
        <Modal  show={this.state.show} 
                handleClose={this.hideModal} 
                actionName = "edit" 
                handleAction = {this.editPossessionCount} 
                selectArray = {this.possessions} 
        >
        </Modal>
        <button type="button" onClick={this.showModal}>
          Open
        </button>
      </main>
    );
  }


}

export default Dashboard