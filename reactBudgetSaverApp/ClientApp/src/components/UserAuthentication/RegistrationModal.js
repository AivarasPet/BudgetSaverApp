import React, { Component } from "react";
import './../modal.css';

const RegistrationModal = ({ handleClose, handleAction, show}) => {
    const showHideClassName = show ? "modal display-block" : "modal display-none";

    let email = "", password = "";

    function handleEmailChange (event)  {
        this.email = event.target.value;
    }

    function handlePasswordChange(event) {
        this.password = event.target.value;
    }

    return (
        <div className={showHideClassName}>
            <form className="modal-main">
                
                <div style={{ marginLeft: 20, marginTop: 20, width: '86%' }}>
                    <input className='input' onChange={handleEmailChange} type='text' placeholder='Email'/>
                </div>
                <div style={{ marginLeft: 20, marginTop: 20, width: '86%' }}>
                    <input className='input' onChange={handlePasswordChange} type='text' placeholder='Password'/>
                </div>
                <div className='form-group row' style={{ marginLeft: 20, marginTop: 20, width: '86%' }}>
                    <button className='blackButton' style={{ marginTop: 20, marginRight: 10, float: 'right' }} type="button" onClick={handleClose}>
                        Close
                    </button>
                    <button className='blackButton' style={{ marginTop: 20, marginRight: 10, float: 'right' }} type="button" >
                        Register
                    </button>
                </div>

            </form>
        </div>
    );
};
export default RegistrationModal