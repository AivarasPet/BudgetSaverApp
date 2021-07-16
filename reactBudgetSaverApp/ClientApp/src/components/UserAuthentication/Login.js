import React, { Component } from 'react';
import './UserAuth.css';
import * as AuthService from './AuthService'
import RegistrationModal from './RegistrationModal'

const styles = {
    form: {
      textAlign: 'center'
    }
  }

export class Login extends Component {
    static displayName = Login.name;

    constructor(props) {
        super(props);
        this.state = {
            email:"",
            password:"",
            loading: true,
            doShowRegistrationModal : false
        };       
    }

    closeTheRegistrationModal = event => {
        event.preventDefault();
        this.setState({loading: false,doShowRegistrationModal : false})
    }
    openTheRegistrationModal = event => {
        event.preventDefault();
        this.setState({loading: false,doShowRegistrationModal : true})
        
    }

    registerNewUser = () => {
        //this.setState({loading:false})
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

                ></RegistrationModal>         
            </div>
        );
    }

    LogInPressed = async (event) => {
        console.log("vyksta");
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