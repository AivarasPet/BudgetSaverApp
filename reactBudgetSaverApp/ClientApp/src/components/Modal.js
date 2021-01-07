import React, { Component } from "react";
import './modal.css';
import Select from 'react-select';





const Modal = ({ handleClose, handleAction, show, actionName, selectArray}) => {
  const showHideClassName = show ? "modal display-block" : "modal display-none";

  let amount = 0, selectedPossession = "";

  return (
    <div className={showHideClassName}>
      <form className="modal-main">
        <Select placeholder="Possession" options = {selectArray} onChange={(event) => {selectedPossession = event.value}} > </Select>
        <div><input type="number" onChange={({ target }) => {amount = target.value}}/> </div>
        <button style={{float: 'right'}} type="button" onClick={() => handleAction(selectedPossession, amount)}>
            {actionName}
        </button>
        <button style={{float: 'right'}} type="button" onClick={handleClose}>
            Close
        </button>
      </form>
    </div>
  );
};
export default Modal