import { Button, Navbar } from "react-bulma-components";

export default function AppHeader() {
  return (
    <Navbar>
      <Navbar.Brand>
        <Navbar.Item href="#">

        </Navbar.Item>
        <Navbar.Burger />
      </Navbar.Brand>
      <Navbar.Menu>
        <Navbar.Container>
          <Navbar.Item href="#">React GraphQL Client Example</Navbar.Item>
          <Navbar.Item href="#">About</Navbar.Item>
        </Navbar.Container>
        <Navbar.Container align="right">
          <Navbar.Item href="https://github.com/bervproject/react-graphql-client">
            <Button color="dark">
              Github
            </Button>
          </Navbar.Item>
        </Navbar.Container>
      </Navbar.Menu>
    </Navbar>
  );
}
