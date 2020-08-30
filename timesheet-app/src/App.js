import React, { useState } from "react";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import { ThemeProvider } from "@material-ui/styles";
import theme from "./app/ui/Theme";
import TimesheetTable from "./features/dashboard/TimesheetTable";
import NavBar from "./features/nav//Navbar";
import SecondaryNav from "./features/nav/SecondaryNav";
import ProjectList from "./features/projects/ProjectsList";
import TaskList from "./features/tasks/TaskList";
import TeamList from "./features/team/TeamList";
import ReportList from "./features/reports/ReportList";
import LandingPage from "./LandingPage";

function App() {
  const [selectedIndex, setSelectedIndex] = useState(0);
  const [value, setvalue] = useState(0);

  return (
    <ThemeProvider theme={theme}>
      <BrowserRouter>
        <NavBar />
        <SecondaryNav />
        <Switch>
          <Route
            exact
            path="/"
            render={(props) => (
              <TimesheetTable {...props} setSelectedIndex={setSelectedIndex} />
            )}
          />
          <Route
            exact
            path="/projects"
            render={(props) => (
              <ProjectList {...props} setSelectedIndex={setSelectedIndex} />
            )}
          />
          <Route
            exact
            path="/tasks"
            render={(props) => (
              <TaskList {...props} setSelectedIndex={setSelectedIndex} />
            )}
          />
          <Route exact path="/team" component={() => <div>team</div>} />
          <Route exact path="/reports" component={() => <div>reports</div>} />
          <Route
            exact
            path="/timesheets"
            component={() => <div>Timesheets</div>}
          />
          <Route
            exact
            path="/pendingapproval"
            component={() => <div>Pending Approval</div>}
          />
          <Route
            exact
            path="/unsubmitted"
            component={() => <div>Unsubmitted</div>}
          />
          <Route exact path="/archive" component={() => <div>Archive</div>} />
          <Route
            exact
            path="/profile"
            component={() => <div>Profile page</div>}
          />
          <Route
            exact
            path="/myaccount"
            component={() => <div>My Account</div>}
          />
        </Switch>
      </BrowserRouter>
    </ThemeProvider>
  );
}

export default App;
