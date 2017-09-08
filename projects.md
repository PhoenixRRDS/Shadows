---
layout: page
title: Projects
---

{% assign projects = site.assets %}

<div class = "browse">

{% for project in projects %}
	{% include browse-medium.html asset=project %}
{% endfor %}

</div>

<style>
.browse {
	max-width: 967px;
	margin: auto;
}
</style>
