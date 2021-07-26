import React from "react";
import { makeStyles } from "@material-ui/core/styles";
import OutlinedInput from "@material-ui/core/OutlinedInput";
import InputLabel from "@material-ui/core/InputLabel";
import InputAdornment from "@material-ui/core/InputAdornment";
import FormControl from "@material-ui/core/FormControl";

const useStyles = makeStyles((theme) => ({
  root: {
    display: "flex",
    flexWrap: "wrap"
  },
  margin: {
    margin: theme.spacing(1)
  },
  withoutLabel: {
    marginTop: theme.spacing(3)
  },
  textField: {
    width: "25ch"
  }
}));

export default function MoneyField({label, symbol, labelWidth, returnInput}) {
  const classes = useStyles();


  return (
    <FormControl fullWidth className={classes.margin} variant="outlined">
      <InputLabel htmlFor="outlined-adornment-amount">{label}</InputLabel>
      <OutlinedInput
        id="outlined-adornment-amount"
        onChange={(event) => {returnInput(event.target.value)}}
        startAdornment={<InputAdornment position="start">{symbol}</InputAdornment>}
        labelWidth={labelWidth}
      />
    </FormControl>
  );
}
