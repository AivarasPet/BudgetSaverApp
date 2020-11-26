import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Transactions } from './components/Transactions';
import { Possessions } from './components/Possessions';
import { Statistics } from './components/Statistics';
import { Goals } from './components/Goals';
import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
        <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/transactions' component={Transactions} />
        <Route path='/statistics' component={Statistics} />
        <Route path='/possessions' component={Possessions} />
      </Layout>
    );
  }
}
