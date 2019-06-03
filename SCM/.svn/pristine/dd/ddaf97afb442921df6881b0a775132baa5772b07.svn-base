<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">
  <xsl:output method="html" />
  <xsl:template match="/">
    <HTML xmlns="http://www.w3.org/1999/xhtml">
      <head>
        <title></title>
        <link  href="styles/xp.menu.css" type="text/css" rel="stylesheet"/>
        <script src="scripts/xp.menu.js" type="text/javascript"></script>
        <style>
          body {
          margin-left: 0px;
          margin-top: 0px;
          margin-right: 0px;
          margin-bottom: 0px;
          }
          .STYLE1 {
          font-size: 12px;
          color: #FFFFFF;
          }
          .STYLE3 {
          font-size: 12px;
          color: #033d61;
          }
          .menu_title SPAN {
          FONT-WEIGHT: bold; LEFT: 3px; COLOR: #ffffff; POSITION: relative; TOP: 2px
          }
          .menu_title2 SPAN {
          FONT-WEIGHT: bold; LEFT: 3px; COLOR: #FFCC00; POSITION: relative; TOP: 2px
          }
        </style>
        </head>
        <body >
            <div id="tt" style="height:-105;overflow:hidden"/>
            <table width="165" height="100%" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td height="28" background="images/xp/main_40.gif">
                  <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td width="19%"> </td>
                      <td width="81%" height="20">
                        <div class="STYLE1" id ="notification">
                          功能菜单
                        </div>
                      </td>
                    </tr>
                  </table>
                </td>
              </tr>
              <tr>
                <td valign="top">
                  <table width="151" border="0" align="center" cellpadding="0" cellspacing="0">                    
                    <xsl:for-each select="/Modules/Module">
                      <xsl:apply-templates select="." mode="Module" />
                    </xsl:for-each>
                  </table>
                </td>
              </tr>
              <tr>
                <td height="18" background="images/xp/main_58.gif">
                  <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td height="18" valign="bottom">
                        <div align="center" class="STYLE3"></div>
                      </td>
                    </tr>
                  </table>
                </td>
              </tr>
            </table>
            <script type="text/javascript">preparemenu();</script>
        </body>
      </HTML>
    </xsl:template>
  <xsl:template match="Module" mode="Module">
    <xsl:variable name="M_DIV">
      lay_m_<xsl:value-of select="@Index" />
    </xsl:variable>
    <xsl:variable name="M_NAME">
      <xsl:value-of select="concat('[',@Name,']')" />
    </xsl:variable>
    <tr>
      <td>
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td height="23" background="images/xp/main_47.gif" class="menu_title" onMouseOver="this.className='menu_title2';"  onMouseOut="this.className='menu_title';" style="cursor:hand">
              <xsl:attribute name="id">
                <xsl:value-of select="concat('imgmenu',@Index)" />
              </xsl:attribute>
              <xsl:attribute name="onclick">
                showsubmenu(<xsl:value-of select="@Index" />)
              </xsl:attribute>
              <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td width="18%" style="height: 19px"> </td>
                  <td width="82%" class="STYLE1" style="height: 19px">
                    <xsl:value-of select="@Name" />
                  </td>
                </tr>
              </table>
            </td>
          </tr>
          <tr>
            <td background="images/xp/main_51.gif" >
              <xsl:attribute name="id">
                <xsl:value-of select="concat('submenu',@Index)" />
              </xsl:attribute>
              <div class="sec_menu" >
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td>
                      <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
                        <xsl:attribute name="id">
                          <xsl:copy-of select="$M_DIV" />
                        </xsl:attribute>
                        <xsl:call-template name = "Function" >
                          <xsl:with-param name="parentLayer" select="$M_DIV"/>
                          <xsl:with-param name="moduleName" select="$M_NAME"/>
                        </xsl:call-template>
                      </table>
                    </td>
                  </tr>
                  <tr>
                    <td height="5">
                      <img src="images/xp/main_52.gif" width="151" height="5" />
                    </td>
                  </tr>
                </table>
              </div>
            </td>
          </tr>
        </table>
      </td>
    </tr>
  </xsl:template>
  <xsl:template name="Function">
    <xsl:param name="parentLayer"/>
    <xsl:param name="moduleName"/>
    <xsl:for-each select="./Functions/Function">
      <xsl:variable name="F_DIV">
        <xsl:value-of select="@Index" />
      </xsl:variable>
      <xsl:variable name="F_NAME">
        <xsl:value-of select="concat($moduleName,'-','[',@Name,']')" />
      </xsl:variable>
      <tr>
        <td width="16%" height="25">
          <div align="center">
            <img src="images/xp/left.gif" width="10" height="10" />
          </div>
        </td>
        <td width="84%" height="23">
          <table width="95%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td height="20" style="cursor:hand" >
                <span class="STYLE3">
                  <xsl:value-of select="@Name" />
                </span>
              </td>
            </tr>
          </table>
        </td>
      </tr>
      <xsl:call-template name = "Page" >
        <xsl:with-param name="functionName" select="$F_NAME"/>
      </xsl:call-template>
    </xsl:for-each>
  </xsl:template>
  <xsl:template name="Page">
    <xsl:param name="functionName"/>
    <xsl:for-each select="./Pages/Page">
      <xsl:variable name="P_NAME">
        <xsl:value-of select="concat($functionName,'-','[',@Name,']')" />
      </xsl:variable>
    <tr>
      <td width="16%" height="25"> </td>
      <td width="84%" height="23">
        <table border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="10%" height="25">
              <div align="center">
                <img src="images/xp/left.gif" width="10" height="10" />
              </div>
            </td>
            <td width="100%" height="23">
              <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; " onmouseout="this.style.borderStyle='none'">
                    <xsl:attribute name="onclick">
                      Redirect('<xsl:value-of select="@Href" />','<xsl:value-of select="@Name" />');
                  </xsl:attribute>
                    <span class="STYLE3">
                      <xsl:value-of select="@Name" />
                    </span>
                  </td>
                </tr>
              </table>
            </td>
          </tr>
        </table>
      </td>
    </tr>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>