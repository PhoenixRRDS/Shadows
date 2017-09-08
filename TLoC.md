---
layout: page
title: Thousand Lines of Code
---

![logo](https://raw.githubusercontent.com/BytesClub/BytesClub.github.io/master/images/tloc.png)

Thousand Lines of Code (TLoC) is a open source program initiated by Bytes Club to bring more students into open source development. Students will have to work under their mentors on one or more project for a span of 3 months during their semester breaks

### Timeline

* **17-June-2017:** Program Launched and Idea Accepting Starts
* **14-July-2017:** Idea Accepting Ends
* **15-July-2017:** Peer Bonding and Project Analysis
* **1st-August-2017:** Actual Coding Program Starts
* **30-September-2017:** Program Ends and Result Declaration

### Available Projects

---

#### [Chalk](https://github.com/BytesClub/chalk)
A command line text editor written in C

**Brief Explanation**: Currently chalk is in a very early stage of development. The idea of this project is to complete the basic version 1.0 of chalk along with it's documentation: <br>
* Accepting input from the user and producing the output 
* Ability to view and edit the contents of a file effectively 
* Searching 
* Syntax highlighting
* Documentation of the overall project, using [Sphinx](http://www.sphinx-doc.org/en/stable/) <br>

**Technologies**: C, CLI<br/>
**Maintainer**: [Rudra Nil Basu](https://github.com/RudraNilBasu)<br>
**Communication**: [BytesClub/General](https://gitter.im/Bytes_Club/General) on Gitter

**Selected candidate**: Satyam Kumar

---

#### [MAKAUT Connect](https://github.com/BytesClub/MAKAUT-Connect)
A web application for MAKAUT students to get notified about lectures, events and exams.

**Brief Explanation**: The project MAKAUT Connect currently has just a sample HTML page, with header and logo. The project is Component driven based on Virtual DOM concept of [React](https://facebook.github.io/react/). We will be using [Express](https://expressjs.com/) for our back-end. Key features of this project: <br/>
* Whole project is in NodeJS running in Chrome V8 engine.
* Codebase will be wriiten in ES6 Standard following our [Coding Style](/docs/coding_style.pdf).
* We will be using Redux for Web API request handling and React-Router for routing purpose.
* For REST API service we will be using Express as framework MongoDB/MySQL as database. <br/>

**Technologies**: NodeJS, React-Redux-Webpack, RESTful API<br/>
**Maintainer**: [Progyan Bhattacharya](https://github.com/Progyan1997)

**Selected candidate**: Supriyo Das

---

#### [ServerX](https://github.com/BytesClub/serverX)
A HTTP/HTTPS Web Server Handler by (C) Bytes Club

**Brief Explanation**: The codebase of serverX is a clone of [CS50 Problem Set 5](http://cdn.cs50.net/2016/x/psets/6/pset6/pset6.html) with additional cross-platform dependency resolution. This project works in both Linux and Windows architecture. Key things about this project: <br/>
* The code is completely written in C with few or more library dependencies.
* We are using web socket to create network connections.
* The project currently is Single-Threaded, but will be Multi-Threaded soon.
* The codebase currently rely on shell and interpreter for executing scripts. <br/>

**Technologies**: C, HTTP, Socket.IO<br/>
**Maintainer**: [Progyan Bhattacharya](https://github.com/Progyan1997)

**Selected candidate**: Pinak Roy Chowdury

---

#### [Tic Tac Toe](https://github.com/BytesClub/Tic_Tac_Toe)
A simple Tic_Tac_Toe implementation in C

**Brief Explanation**: Tic Tac Toe is the biggest collaborative project on Bytes Club. This is a simple board game impleneted in C to run in terminal. The project currently has: <br/>
* Static Credit screen followed by a Graphical representation of the board using ASCII characters.
* Reload table after each moves given by user.
* Determines winner and avoids multiple input at same place.
* Currently working on Bot player with/without AI capability. <br/>

**Technologies**: C, CLI, AI<br/>
**Maintainer**: [Progyan Bhattacharya](https://github.com/Progyan1997)

---

#### [Xplode](https://github.com/BytesClub/Xplode)
A 2D Game based on OpenGL 

**Bried Explanation**: Xplode is currently in a very basic stage of development and we would like to complete the first version of Xplode which would include:
* Fully functional gameplay
* Main menu screen and credits screen
* Documentation using [Sphinx](http://www.sphinx-doc.org/en/stable/)

**Technologies**: C++, OpenGL<br>
**Maintainer**: [Rudra Nil Basu](https://github.com/RudraNilBasu)<br>
**Communication**: [BytesClub/General](https://gitter.im/Bytes_Club/General) on Gitter

---

### How to apply

Submit your proposal in a Google Doc format to the [BytesClub mailing list](mailto:bytes-club@googlegroups.com). Make sure you provide permission for mentors to feedbacks. A sample template can be found [here](https://github.com/BytesClub/Guidelines/wiki/Thousand-Lines-of-Code:-Application-Template)

#### Pre-Requisite
* **Hardware**: Any working computer with atleast pentium core processor and 512MiB RAM
* **Operating System**: Any popular Linux distribution (Ubuntu 16.04 LTS is encouraged for new comers)
* **Version Control System**: Git v2.x (recommended, v1.8.x will also work, but may require modifications)
* **Tracker**: [GitHub in Terminal](https://www.npmjs.com/package/ghb) is Bytes Club's own [repo](https://github.com/BytesClub/ghb).
* **Other**: An active [GitHub](https://github.com/) account and pre-requisites of particular projects available in Docs.

#### Things to keep in mind:

0. Make sure you join the Bytes Club [Mailing list](https://groups.google.com/forum/#!forum/bytes-club) and [Gitter Channel](https://gitter.im/Bytes_Club/General). All conversation will take place there.
1. Do not set impossible goal. We are trying to do some real work here. So be as practical as possible.
2. Participants can either work on issues registered already or on their independent ideas. In any case, there will be fixed boundary to which he/she can work on decided by the mentor.
3. Introduce yourself properly mentioning your knowledge and experience properly, remember we will guide you likewise.
4. Although it is okay to propose idea for multiple projects but we strongly encourage you to work on one.
5. In case of multiple submission, the last proposal will be taken into account while evaluating.
6. Communication is an important part of collaborative work. So try to be active as much as possible on our [gitter channel](https://gitter.im/Bytes_Club/General).
7. We will review work progress and our goals in every week or so, according your mentor.
8. The timeline is fixed and we are strict about our [Contribution Guidelines](/contributing/).
9. Make sure you have some prior contributions to the projects you are planning to contribute during this period, it will be easier for you to get selected if you have prior knowledge about the codebase.

### Prizes

On successful completion, the students will recieve:

* A Bytes Club T-Shirt
