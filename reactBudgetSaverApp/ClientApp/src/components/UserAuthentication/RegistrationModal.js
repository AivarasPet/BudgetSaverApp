import React, { Component } from "react";
import './../modal.css';

const RegistrationModal = ({ handleClose, handleAction, show, postRegistrationState}) => {
    const showHideClassName = show ? "modal display-block" : "modal display-none";

    let email = "", password = "";
    var postRegistrationMessage


    switch(postRegistrationState) 
    {
        case 0: postRegistrationMessage = <h1></h1>; break;
        case 1: postRegistrationMessage = <h1 style={{color: '#64e04e'}}> SUCCESS! </h1>; break;
        case 2: postRegistrationMessage = <h1 style={{color: '#FF0000'}}> USER ALREADY EXISTS! </h1>; break;
    }

    return (

        <div className={showHideClassName}>
            <form className="modal-main">
                
                <div style={{ marginLeft: 20, marginTop: 20, width: '86%' }}>
                    <input className='input' onChange={({ target }) => { email = target.value }} type='text' placeholder='Email'/>
                </div>
                <div style={{ marginLeft: 20, marginTop: 20, width: '86%' }}>
                    <input className='input' onChange={({ target }) => { password = target.value }} type='text' placeholder='Password'/>
                </div>
                <div className='form-group row' style={{ marginLeft: 20, marginTop: 20, width: '86%' }}>
                    <button className='blackButton' style={{ marginTop: 20, marginRight: 10, float: 'right' }} type="button" onClick={handleClose}>
                        Close
                    </button>
                    <button className='blackButton' style={{ marginTop: 20, marginRight: 10, float: 'right' }} type="button" onClick={() => handleAction(email, password)}>
                        Register
                    </button>
                </div>
                <div className='form-group row' style={{ marginLeft: 20, marginTop: 20, width: '86%' }}>
                    {postRegistrationMessage}
                </div>

            </form>
        </div>
    );
};
export default RegistrationModal