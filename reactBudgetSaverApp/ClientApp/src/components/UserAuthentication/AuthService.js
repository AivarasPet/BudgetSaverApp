import decode from 'jwt-decode';
import axios from 'axios';
import * as jwt_decode from 'jwt-decode';

const tokenKey = "token";

   export async function Login (email, password) {
    
    
    var user = { email: email, password: password };
    console.log(user);
    const message = {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(user)
    };
    var whatToRet = null;
    // console.log("hahhaha");
    // await fetch('User/LoginAttempt', message)
    // .then(response => {
    //     if (response.ok) {
    //         return response.text();
    //     } else {
    //         response.text().then((s) => window.alert(s));//cia reiks fixint kad butu reactinis solutionas
    //         return null;
    //     }
    // }).then(data => {
    //     if (data !== null) {
    //       setToken(data);
    //       whatToRet = data;
    //     }
          
    // });
    // return whatToRet;


    const response = await fetch('https://localhost:5001/User/LoginAttempt', message);
         if (!response.ok) {
          console.log("Failure to Login")
          return null;
         }
    const answer = await response.text(); 
    setToken(answer);
    console.log(answer);
    return answer;
    //if(whatToReturn === null) return null;
    
    //this.setToken(whatToReturn);
    //return whatToReturn
    // return answer;            //response.text().then((s) => window.alert(s));//cia reiks fixint kad butu reactinis solutionas
      
  }

  export function loggedIn() {
    // Checks if there is a saved token and it's still valid
    const token = this.getToken(); // GEtting token from localstorage
    return !!token && !this.isTokenExpired(token); // handwaiving here
  }

  export function isTokenExpired(token) {
    try {
      const decoded = decode(token);
      if (decoded.exp < Date.now() / 1000) {
        // Checking if token is expired. N
        return true;
      } else return false;
    } catch (err) {
      return false;
    }
  }

  export function setToken(idToken) {
    // Saves user token to localStorage
    localStorage.setItem(tokenKey, idToken);
  }

  export function getToken() {
    // Retrieves the user token from localStorage
    return localStorage.getItem(tokenKey);
  }

  export function logout() {
    // Clear user token and profile data from localStorage
    localStorage.removeItem(tokenKey);
  }

  export function getProfile() {
    // Using jwt-decode npm package to decode the token
    return decode(this.getToken());
  }

//   export function fetch(url, options) {
//     // performs api calls sending the required authentication headers
//     const headers = {
//       Accept: 'application/json',
//       'Content-Type': 'application/json',
//     };

//     // Setting Authorization header
//     // Authorization: Bearer xxxxxxx.xxxxxxxx.xxxxxx
//     if (this.loggedIn()) {
//       headers['Authorization'] = 'Bearer ' + this.getToken();
//     }

//     return fetch(url, {
//       headers,
//       ...options,
//     })
//       .then(this._checkStatus)
//       .then(response => response.json());
//   }

  export function _checkStatus(response) {
    // raises an error in case response status is not a success
    if (response.status >= 200 && response.status < 300) {
      // Success status lies between 200 to 300
      return response;
    } else {
      var error = new Error(response.statusText);
      error.response = response;
      throw error;
    }
  }
