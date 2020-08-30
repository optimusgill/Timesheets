import React, { Fragment, useEffect, useState } from "react";
import { Link } from "react-router-dom";
import { makeStyles, withStyles } from "@material-ui/core/styles";
import BottomNavigation from "@material-ui/core/BottomNavigation";
import BottomNavigationAction from "@material-ui/core/BottomNavigationAction";
import Grid from "@material-ui/core/Grid";
import AccessTimeIcon from "@material-ui/icons/AccessTime";
import RecentActorsIcon from "@material-ui/icons/RecentActors";
import ListAltIcon from "@material-ui/icons/ListAlt";
import PersonIcon from "@material-ui/icons/Person";
import MenuBookIcon from "@material-ui/icons/MenuBook";
import Tabs from "@material-ui/core/Tabs";
import Tab from "@material-ui/core/Tab";

const useStyles = makeStyles((theme) => ({
  root: {
    flexGrow: 0,
  },
  tabContainer: {
    marginLeft: "auto",
    backgroundColor: "#DFE6E9",
  },
  tabs: {
    ...theme.typography.tabs,
  },
}));

export default function SimpleBottomNavigation() {
  const classes = useStyles();
  const [value, setValue] = React.useState(0);
  const [value2, setValue2] = React.useState(0);
  const [anchorE1, setanchorE1] = useState(null);

  const handleChange = (e, value) => {
    setValue2(value);
  };

  const routes = [
    { name: "Projects", link: "/projects", activeIndex: 0 },
    { name: "Tasks", link: "/tasks", activeIndex: 1 },
    { name: "Teams", link: "/team", activeIndex: 3 },
    { name: "Reports", link: "/reports", activeIndex: 4 },

    { name: "Timesheets", link: "/timesheets", activeIndex: 0 },
    { name: "Pending Approval", link: "/pendingapproval", activeIndex: 1 },
    { name: "Unsubmitted", link: "/unsubmitted", activeIndex: 2 },
    { name: "Archive", link: "/archive", activeIndex: 3 },
  ];

  useEffect(() => {
    if (window.location.pathname === "/projects" && value !== 0) {
      setValue(0);
    } else if (window.location.pathname === "/tasks" && value !== 1) {
      setValue(1);
    } else if (window.location.pathname === "/team" && value !== 2) {
      setValue(2);
    } else if (window.location.pathname === "/reports" && value !== 3) {
      setValue(3);
    } else if (window.location.pathname === "/timesheets" && value2 !== 0) {
      setValue2(0);
    } else if (
      window.location.pathname === "/pendingapproval" &&
      value2 !== 1
    ) {
      setValue2(1);
    } else if (window.location.pathname === "/unsubmitted" && value2 !== 2) {
      setValue2(2);
    } else if (window.location.pathname === "/archive" && value2 !== 3) {
      setValue2(3);
    }
  }, [value, value2]);

  return (
    <div>
      <Grid container spacing={4}>
        <Grid item xs={6}>
          <BottomNavigation
            value={value}
            onChange={(event, newValue) => {
              setValue(newValue);
            }}
            showLabels
            className={classes.root}
          >
            <BottomNavigationAction
              label="Projects"
              icon={<RecentActorsIcon />}
              component={Link}
              to="/projects"
            />
            <BottomNavigationAction
              label="Tasks"
              icon={<ListAltIcon />}
              component={Link}
              to="/tasks"
            />
            <BottomNavigationAction
              label="Team"
              icon={<PersonIcon />}
              component={Link}
              to="/team"
            />
            <BottomNavigationAction
              label="Reports"
              icon={<MenuBookIcon />}
              component={Link}
              to="/reports"
            />
          </BottomNavigation>
        </Grid>
        <Grid
          item
          xs={6}
          container
          direction="row"
          alignItems="flex-start"
          justify="flex-end"
        >
          <Tabs
            value={value2}
            onChange={handleChange}
            className={classes.tabContainer}
          >
            <Tab
              className={classes.tabs}
              label="Timesheets"
              component={Link}
              to="/timesheets"
            />
            <Tab
              className={classes.tabs}
              label="Pending Approval"
              component={Link}
              to="/pendingapproval"
            />
            <Tab
              className={classes.tabs}
              label="Unsubmitted"
              component={Link}
              to="unsubmitted"
            />
            <Tab
              className={classes.tabs}
              label="Archive"
              component={Link}
              to="archive"
            />
          </Tabs>
        </Grid>
      </Grid>
    </div>
  );
}
