import 'bulma/css/bulma.min.css';

import {
  ApolloClient,
  ApolloProvider,
  InMemoryCache
} from "@apollo/client";

import App from './App';
import ReactDOM from 'react-dom';
import reportWebVitals from './reportWebVitals';

const client = new ApolloClient({
  uri: 'https://localhost:7174/graphql',
  cache: new InMemoryCache()
});

ReactDOM.render(
  <ApolloProvider client={client}>
    <App />
  </ApolloProvider>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
