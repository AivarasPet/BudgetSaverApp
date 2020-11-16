import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Transactions } from './components/Transactions';
import { Counter } from './components/Counter';
import { Possessions } from './components/Possessions';
import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/transactions' component={Transactions} />
        <Route path='/possessions' component={Possessions} />
      </Layout>
    );
  }
}
