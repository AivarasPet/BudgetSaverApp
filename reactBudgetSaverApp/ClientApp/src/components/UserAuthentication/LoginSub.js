import React, { Component } from 'react';

const styles = {
    form: {
      textAlign: 'center'
    }
  }
  
  class LoginSub extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            email: "",
            password: ""
        };
    }

    handleEmailChange = (event) => {
        this.setState({ email: event.target.value });
    }

    handlePasswordChange = (event) => {
        this.setState({ password: event.target.value });
    }

    handleOnSubmit = (e) => {
      this.props.LogInCallback(this.state.email, this.state.password);        
      e.preventDefault();
    };
    render() {
      return (
          <form style={styles.form} onSubmit={this.handleOnSubmit}>
            <h4>Welcome Back!</h4>
            <div className='form-group row'>
              <input className='input' onChange={this.handleEmailChange} type='text' placeholder='Email'/>
            </div>
            <div className='form-group row'>
              <input className='input' onChange={this.handlePasswordChange} type='password' placeholder='Password'/>
            </div>
            <div className='form-group row'>
              <button  className='btn' type='submit'>Log In</button>
            </div>

          </form>
        
      )
    }
    
  }
  export default LoginSub;
  
   



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
  
  
