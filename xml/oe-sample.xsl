<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ts="urn:hu.qwaevisz.schema.oe.sample:1">

<xsl:output method="html"/>

<xsl:template match="/">
	<html>
		<head>
			<style>
				h1 {
					font-family			: Georgia, serif;
					font-size			: 22px;
					font-weight			: bold;
					text-align			: center;
					border-bottom		: 1px dotted black;
					margin				: 0px 20px 0px 20px;
					color				: #4444AA;
				}
				
				h2 {
					font-family			: Georgia, serif;
					font-size			: 18px;
					font-weight			: bold;
					margin				: 10px 20px 10px 20px;
					background-color	: #01835b;
					padding				: 5px;
					color				: #dfda0f;
					border-radius		: 5px;
				}
				
				.category {
					float				: right;
				}
				
				ul a {
					text-decoration		: none;
					font-family			: Georgia, serif;
					padding-left		: 5px;
					padding-right		: 5px;
				}
				
				ul a:hover {
					background-color	: #556699;
					border-radius		: 5px;
					color				: white;
				}
				
				.frame {
					margin				: 0px 20px 0px 20px;
					font-family			: Georgia, serif;
				}
				
				.frametable td {
					vertical-align		: top;
					padding				: 5px;
				}
				
				.content {
					text-align			: justify;
					padding-bottom		: 5px;
				}
				
				.content label {
					font-weight			: bold;
					padding-right		: 10px;
				}
			
				.table {
					padding				: 3px;
					border-spacing		: 5px;
					border				: 1px solid #888888;
					border-radius		: 5px;
					white-space			: nowrap;
				}
			
			</style>
		</head>
		<body>
			<xsl:apply-templates />
		</body>
	</html>
</xsl:template>

<xsl:template match="ts:sample">
	<h1>UNI-OBUDA - Sample XML-XSD-XSL example</h1>
	<div class="categorytoc">
		<ul>
			<xsl:for-each select="ts:movie">
				<li>
					<a>
						<xsl:attribute name="href">#<xsl:value-of select="@id"/></xsl:attribute>
						<xsl:attribute name="title"><xsl:value-of select="ts:title"/></xsl:attribute>
						<xsl:value-of select="ts:title"/>
					</a>					
				</li>
			</xsl:for-each>
		</ul>		
	</div>
	<xsl:apply-templates select="ts:movie" />
</xsl:template>

<xsl:template match="ts:movie">
	<a>
		<xsl:attribute name="name"><xsl:value-of select="@id"/></xsl:attribute>
	</a>
	<h2>
		<xsl:value-of select="ts:title" />
		<span class="category"><xsl:value-of select="ts:category" /></span>
	</h2>
	<div class="frame">
		<table class="frametable">
			<tr>
				<td>
					<div class="content"><xsl:value-of select="ts:description" /></div>
					<div class="content"><label>Director</label> <span class="pattern"><xsl:value-of select="ts:director" /></span></div>
					<div class="content"><label>Writer</label> <span class="pattern"><xsl:value-of select="ts:writer" /></span></div>					
				</td>
				<td>
					<table class="table">
						<thead>
							<tr>
								<th>Actor / Actress</th>
								<th>Character</th>
							</tr>
						</thead>
						<tbody>
							<xsl:apply-templates select="ts:actors" />
						</tbody>
					</table>				
				</td>
			</tr>
		</table>
	</div>
</xsl:template>

<xsl:template match="ts:actors">
	<xsl:apply-templates select="ts:actor" />
</xsl:template>

<xsl:template match="ts:actor">
	<tr>
		<td><xsl:apply-templates select="ts:name" /></td>
		<td><xsl:apply-templates select="ts:character" /></td>
	</tr>
</xsl:template>

</xsl:stylesheet>