import React, { Component } from 'react';
import './UserAuth.css';
import * as AuthService from './AuthService'
import RegistrationModal from './RegistrationModal'


const styles = {
    form: {
      textAlign: 'center'
    }
}

const sleep = ms => new Promise(resolve => setTimeout(resolve, ms))

export class Login extends Component {
    static displayName = Login.name;

    constructor(props) {
        super(props);
        this.state = {
            email:"",
            password:"",
            loading: true,
            doShowRegistrationModal : false,
            postRegistrationState: 0
        };       
    }

    closeTheRegistrationModal = event => {
        event.preventDefault();
        this.setState({loading: false,doShowRegistrationModal : false})
    }
    openTheRegistrationModal = event => {
        event.preventDefault();
        this.setState({loading: false,doShowRegistrationModal : true, postRegistrationState: 0})
        
    }

    registerNewUser = async (email, password) => {       
        var user = { email: email, password: password };
        const message = {
            method: 'post',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(user)
        }; 
        const response = await fetch('User/RegisterAttempt', message);
        if (!response.ok) {
            this.setState({postRegistrationState: 2}); //fail
        }
        else this.setState({postRegistrationState: 1});
        await sleep(1000);
        this.setState({doShowRegistrationModal: false});
    }

    componentDidMount() {
        if(AuthService.loggedIn()) this.props.LogInSuccesful();
        this.setState({loading:false})
    }
    

    render() {   
        return (
            <div>
                <form style={styles.form} >
                    <h4>Welcome Back!</h4>
                    <div className='form-group row'>
                    <input className='input' onChange={this.handleEmailChange} type='text' placeholder='Email'/>
                    </div>
                    <div className='form-group row'>
                    <input className='input' onChange={this.handlePasswordChange} type='password' placeholder='Password'/>
                    </div>
                    <div className='form-group row'>
                    <button  className='btn' onClick = {this.LogInPressed}>Log In</button>
                    <button className='btn' onClick={this.openTheRegistrationModal}>Register</button>
                    </div>

                </form>
        
                <RegistrationModal show = {this.state.doShowRegistrationModal}
                    handleClose = {this.closeTheRegistrationModal}
                    handleAction = {this.registerNewUser}
                    postRegistrationState = {this.state.postRegistrationState}
                ></RegistrationModal>         
            </div>
        );
    }

    LogInPressed = async (event) => {
        let data = await AuthService.Login(this.state.email, this.state.password);
        console.log(data)
        if(data !== null) this.props.LogInSuccesful();
        this.setState({loading:false})
    }

    
    handleEmailChange = (event) => {
        this.setState({ email: event.target.value, loading:false });
    }

    handlePasswordChange = (event) => {
        this.setState({ password: event.target.value, loading:false });
    }

}

class Form extends React.Component {
    render () {
      const {children, title} = this.props
      return (
        <div className='col-md-6 mx-auto'>
          <header>
            <h1>{title}</h1>
          </header>
          {children}
        </div>
      )
    }
  }