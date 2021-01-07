import React, { Component } from "react";
import './modal.css';
import Select from 'react-select';





const Modal = ({ handleClose, handleAction, show, actionName, selectArray, inputField }) => {
    const showHideClassName = show ? "modal display-block" : "modal display-none";

    let amount = 0, selectedPossession = "";

    return (
        <div className={showHideClassName}>
            <form className="modal-main">
                <div style={{ marginLeft: 20, marginTop: 20, width: '86%' }}>
                    <Select placeholder="Possession" options={selectArray} onChange={(event) => { selectedPossession = event.value }}> </Select>
                </div>
                {inputField ? <div><input type="number" placeholder="  Amount" onChange={({ target }) => { amount = target.value }} style={{ marginLeft: 20, width: "86%"}}/> </div> : <p></p>}
                <button style={{ marginTop: 20, marginRight: 10, float: 'right' }} type="button" onClick={handleClose}>
                    Close
                </button>
                <button style={{ marginTop: 20, marginRight: 10, float: 'right' }} type="button" onClick={() => handleAction(selectedPossession, amount)}>
                    {actionName}
                </button>
            </form>
        </div>
    );
};
export default Modal