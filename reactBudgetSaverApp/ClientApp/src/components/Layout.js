import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './NavMenu';
import { Login } from './UserAuthentication/Login';
import * as authService from './UserAuthentication/AuthService';

export class Layout extends Component {
  static displayName = Layout.name;

  constructor(props) {
    super(props);
    this.state = {
        loggedIn: false,           
        loading: 0,
        JwtToken: ""
    }
  }

  componentDidCatch() {
    
  }

  LogInSuccesful = (data) => {
    this.setState({loggedIn: true, JwtToken: data});
    window.alert(data);
  }

  render () {
    let contents;
    if(false ) {//this.state.loggedIn
      contents = <div>
      <NavMenu />
      <Container>
        {this.props.children}
      </Container>
    </div>;
    }
    else {
      contents = <Container><Login LogInSuccesful={this.LogInSuccesful}></Login></Container>;
    }
    return (
      contents
    ); 
  }
}
