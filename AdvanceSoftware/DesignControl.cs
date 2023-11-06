using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSoftware
{
    internal class DesignControl : Design
    {
     
        public void runCommands(String strtxt)
        {
            string errMsg = string.Empty;
            string strCommand = string.Empty;
            Boolean runFlg = true;
            int cmdX = 0, cmdY = 0, cmdz = 0;
            string[] arrCommand = strtxt.ToLower().Split(new string[] { ";" }, StringSplitOptions.None);
            string[] oneCommand;

                for (int i = 0; i < arrCommand.Count(); i++)
                {
                    if (arrCommand[i].Trim().ToString() != string.Empty)
                    {
                        oneCommand = arrCommand[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < oneCommand.Count(); j++)
                        {
                            if (oneCommand[j].ToString().Trim().Equals("moveto"))
                            {
                                if (oneCommand.Count() != 3)
                                {
                                    errMsg = errMsg + "Command no. " + (i + 1).ToString() + " is invalid!\n";
                                    runFlg = false;
                                    break;
                                }
                                else
                                {
                                    if (checkNumber(oneCommand[j + 1].Trim(), ref cmdX))
                                    {
                                        if (checkNumber(oneCommand[j + 2].Trim(), ref cmdY))
                                        {
                                            if (runFlg)
                                            {
                                            MovePoint(cmdX, cmdY);
                                            }
                                        }
                                        else
                                        {
                                            errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                            runFlg = false;
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                        runFlg = false;
                                    }
                                    j = j + 2;
                                }

                            }
                            else if (oneCommand[j].ToString().Trim().Equals("drawto"))
                            {
                                if (oneCommand.Count() != 3)
                                {
                                    errMsg = errMsg + "Command no " + i.ToString() + " is invalid!\n";
                                    runFlg = false;
                                    break;
                                }
                                else
                                {
                                    if (checkNumber(oneCommand[j + 1].Trim(), ref cmdX))
                                    {
                                        if (checkNumber(oneCommand[j + 2].Trim(), ref cmdY))
                                        {
                                            if (runFlg)
                                            {
                                                DrawLine(cmdX, cmdY);
                                            }
                                        }
                                        else
                                        {
                                            errMsg = errMsg + " Invalid number at command no " + i.ToString() + "!\n";
                                            runFlg = false;
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + i.ToString() + "!\n";
                                        runFlg = false;
                                    }
                                    j = j + 2;
                                }
                            }
                            else if (oneCommand[j].ToString().Trim().Equals("circle"))
                            {
                                if (oneCommand.Count() != 2)
                                {
                                    errMsg = errMsg + "invalid number of parameters for circle " + (i + 1).ToString() + "\n";
                                    runFlg = false;
                                    break;
                                }
                                else
                                {
                                    if (checkNumber(oneCommand[j + 1].Trim(), ref cmdX))
                                    {
                                        if (runFlg)
                                        {
                                            DrawCircle(cmdX);
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Non numeric parameter " + (i + 1).ToString() + "\n";
                                        runFlg = false;
                                    }
                                    j = j + 1;
                                }
                            }

                            else if (oneCommand[j].ToString().Trim().Equals("pen"))
                            {
                                if (oneCommand.Count() != 2)
                                {
                                    errMsg = errMsg + "invalid number of parameters for circle " + (i + 1).ToString() + "\n";
                                    runFlg = false;
                                    break;
                                }
                                else
                                {
                                    string val = oneCommand[j + 1].Trim();
                                    if (val.Equals("red"))
                                    {
                                        DesignValues.fillColour = new SolidBrush(Color.Red);
                                        DesignValues.pointerColor = Color.Red;
                                    }
                                    else if (val.Equals("green"))
                                    {
                                        DesignValues.fillColour = new SolidBrush(Color.Green);
                                        DesignValues.pointerColor = Color.Green;
                                    }
                                    else if (val.Equals("blue"))
                                    {
                                        DesignValues.fillColour = new SolidBrush(Color.Blue);
                                        DesignValues.pointerColor = Color.Blue;
                                    }
                                    j = j + 1;
                                }
                            }


                            else if (oneCommand[j].ToString().Trim().Equals("square"))
                            {
                                if (oneCommand.Count() != 2)
                                {
                                    errMsg = errMsg + "Command no " + (i + 1).ToString() + " is invalid!\n";
                                    runFlg = false;
                                    break;
                                }
                                else
                                {
                                    if (checkNumber(oneCommand[j + 1].Trim(), ref cmdX))
                                    {
                                        if (runFlg)
                                        {
                                        DrawSquare(cmdX);
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                        runFlg = false;
                                    }
                                    j = j + 1;
                                }
                            }
                            else if (oneCommand[j].ToString().Trim().Equals("rect"))
                            {
                                if (oneCommand.Count() != 3)
                                {
                                    errMsg = errMsg + "Invalid no of argument at command " + (i + 1).ToString() + "!\n";
                                    runFlg = false;
                                    break;
                                }
                                else
                                {
                                    if (checkNumber(oneCommand[j + 1].Trim(), ref cmdX))
                                    {
                                        if (checkNumber(oneCommand[j + 2].Trim(), ref cmdY))
                                        {
                                            if (runFlg)
                                            {
                                            DrawRectangle(cmdX, cmdY);
                                            }
                                        }
                                        else
                                        {
                                            errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                            runFlg = false;
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                        runFlg = false;
                                    }
                                    j = j + 2;
                                }
                            }
                            else if (oneCommand[j].ToString().Trim().Equals("triangle"))
                            {
                                if (oneCommand.Count() != 4)
                                {
                                    errMsg = errMsg + "Command no " + (i + 1).ToString() + " is invalid!\n";
                                    runFlg = false;
                                    break;
                                }
                                else
                                {
                                    if (checkNumber(oneCommand[j + 1].Trim(), ref cmdX))
                                    {
                                        if (checkNumber(oneCommand[j + 2].Trim(), ref cmdY))
                                        {
                                            if (checkNumber(oneCommand[j + 3].Trim(), ref cmdz))
                                            {
                                                if (runFlg)
                                                {
                                                    DrawTriangle(cmdX, cmdY, cmdz);
                                                }
                                            }
                                            else
                                            {
                                                errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                                runFlg = false;
                                            }
                                        }
                                        else
                                        {
                                            errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                            runFlg = false;
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                        runFlg = false;
                                    }
                                    j = j + 3;
                                }
                            }
                            else
                            {
                                errMsg = errMsg + "Unknown Command at line " + (i + 1).ToString();
                                runFlg = false;
                                break;
                            }

                        }
                    }
                }
                if (errMsg.Trim() != string.Empty)
                {
                PrintMessage(errMsg);
                }
                if (DesignValues.isFill)
                {
                    Current_Point(true);
                }
        }
        private Boolean checkNumber(string no, ref int val)
        {
             Boolean isNumber = false;
             if (int.TryParse(no.Trim(), out val))
             isNumber = true;
            return isNumber;
        }

      
    }
}
