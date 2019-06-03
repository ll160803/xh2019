<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">
  <xsl:output method="html" />
  <xsl:template match="/">
    <html>
      <head>
        <title></title>
        <link  href="../../styles/common.css" type="text/css" rel="stylesheet"/>
        <script src="../../scripts/common.js" type="text/javascript"></script>
      </head>
      <body topmargin="0" leftmargin="0" onload="document.getElementById('keepbottom').click();">
      <table cellspacing="0" rules="all" border="1"  style="border-color:#B5D6E6;border-width:1px;border-style:Double;border-collapse:collapse;">
        <tr class="HeaderStyle">
          <th scope="col">任务名称</th>
          <th scope="col">执行过程</th>
          <th scope="col">执行时间</th>
        </tr>
        <xsl:for-each select="/tasks/task">
          <xsl:apply-templates select="." mode="task" />
        </xsl:for-each>
       </table>
        <span id="target"></span>
        <a href="#target" id="keepbottom" ></a>
        <script type="text/javascript">
          setTimeout('window.location.reload();',5000);
        </script>
      </body>
    </html>
  </xsl:template>
  <xsl:template match="task" mode="task">    
    <tr class="RowStyle" onmouseover="if(this!=prevselitem){this.style.backgroundColor='#Efefef'}" onmouseout="if(this!=prevselitem){this.style.backgroundColor='#ffffff'}" >
      <td >
        <nobr>
          <xsl:value-of select="@name" />
        </nobr>
      </td>
      <td >
        <nobr>
          <xsl:value-of select="@msg" />
        </nobr>
      </td>
      <td >
        <nobr>
          <xsl:value-of select="@createtime" />
        </nobr>
      </td>
    </tr>
  </xsl:template>
</xsl:stylesheet>