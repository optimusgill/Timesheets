import React, { PureComponent } from "react";
import { makeStyles } from "@material-ui/core/styles";
import DataTable from "react-data-table-component";
import memoize from "memoize-one";
import axios from "axios";
import Card from "@material-ui/core/Card";
import Button from "@material-ui/core/Button";
import IconButton from "@material-ui/core/IconButton";
import Checkbox from "@material-ui/core/Checkbox";
import CalendarToday from "@material-ui/icons/CalendarToday";
import Delete from "@material-ui/icons/Delete";
import Add from "@material-ui/icons/Add";
import Icon from "@material-ui/core/Icon";
import ArrowLeftIcon from "@material-ui/icons/ArrowLeft";
import ArrowRightIcon from "@material-ui/icons/ArrowRight";
import { Grid, DialogTitle, Typography } from "@material-ui/core";
import { Alert, AlertTitle } from "@material-ui/lab";
import LockIcon from "@material-ui/icons/Lock";
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";

const data = [{ id: 1, project: "Conan the Barbarian", monday: "1982" }];
const useStyles = makeStyles((theme) => ({
  root: {
    "& > span": {
      margin: theme.spacing(2),
      flexgrow: 0,
    },
  },
  paper: {
    padding: theme.spacing(2),
    textAlign: "center",
    color: theme.palette.text.secondary,
  },
  alert: {
    padding: 0,
  },
}));
const customStyles = {
  table: {
    style: {
      fontFamily: "roboto",
    },
  },
};
const columns = [
  {
    name: "Project",
    selector: "project",
    sortable: true,
  },
  {
    name: "Monday",
    selector: "monday",
    right: true,
  },
  {
    name: "Tuesday",
    selector: "tuesday",
    right: true,
  },
  {
    name: "Wednesday",
    selector: "wednesday",
    right: true,
  },
  {
    name: "Thursday",
    selector: "thursday",
    right: true,
  },
  {
    name: "Friday",
    selector: "friday",
    right: true,
  },
  {
    name: "Saturday",
    selector: "saturday",
    right: true,
  },
  {
    name: "Sunday",
    selector: "sunday",
    right: true,
  },
  {
    cell: () => (
      <IconButton color="primary">
        <LockIcon />
      </IconButton>
    ),
    button: true,
  },
];

const weekNumber = "26 August 2020";
const status = "Approved";
const color = status === "Approved" ? "primary" : "secondary";
const titleTimesheet = `Week :${weekNumber}`;

export default function TimesheetTable() {
  const classes = useStyles;
  return (
    <div className={classes.root}>
      <Grid container spacing={3}>
        <Grid
          item
          xs={6}
          container
          direction="row"
          alignItems="center"
          justify="flex-start"
        >
          <IconButton variant="contained" aria-label="previous">
            <ArrowLeftIcon />
          </IconButton>
          <IconButton variant="contained" aria-label="next">
            <ArrowRightIcon />
          </IconButton>
          <Typography variant="subtitle1">{titleTimesheet}</Typography>

          <Button variant="contained" color={color}>
            {status}
          </Button>
        </Grid>
        <Grid
          item
          xs={6}
          container
          direction="row"
          alignItems="flex-start"
          justify="flex-end"
        >
          <IconButton variant="contained">
            <Add />
          </IconButton>
          <IconButton variant="contained" aria-label="previous">
            <CalendarToday />
          </IconButton>
        </Grid>
      </Grid>

      <DataTable
        columns={columns}
        data={data}
        customStyles={customStyles}
        noHeader
        pagination
      />
    </div>
  );
}
