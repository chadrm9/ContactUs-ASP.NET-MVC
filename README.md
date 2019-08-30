Example Site – Contact Us
=========================
04/17/2017

For this quick sample, I created an ASP.NET MVC project with Visual Studio 2017 in a day. Adobe Photoshop CC 2015 was used for gathering design requirements.

Requirements
------------

A designer has delivered the attached contact form for a new page on a site. The HTML/CSS for this page needs to be built out based on the psd the designer delivered Per the client, the contact form only needs to send an email that includes the fields from the form. The client has additionally noted that the map on the page does not have to be interactive. Please also take into account form validation and how this would work responsively.

Notes
=====

Style
-----

Since only a single page was being created on a completely fresh install I opted for pure CSS (Content/Site.css) Bootstrap 3.3.7 although typically I would prefer to use a preprocessor and associated build process.

Responsivity
------------

I accommodated the full horizontal navigation on device-widths > ~1058px rather than falling back to a collapsed nav for all medium devices (992 pixels to 1199 pixels).

Routing
-------

For simplicity, the default route is /Home/ContactUs. A valid form submission redirects here also.

Validation
----------

Model attributes are located in Models/ContactUsModel.cs and validated in the POST Home/ContactUs controller action.
