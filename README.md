# WBUT Code Club Website

[![gitter](https://badges.gitter.im/gitterHQ/gitterHQ.github.io.svg)](https://gitter.im/Bytes_Club/General)

[WBUT In-House Code Club's Official Website](https://bytesclub.github.io/)

### Prerequisites

* [Ruby](https://www.ruby-lang.org/en/)
* [Jekyll](https://jekyllrb.com/)
* [Bundler](http://bundler.io/)

```bash
$ gem install jekyll bundler
```

### Run it on local browser

1. Clone this repository

```bash
git clone https://github.com/BytesClub/BytesClub.github.io.git
```

2. Install dependencies: `$ bundle install`
3. Run the server: `$ bundle exec jekyll serve`
4. From your browser, go to: `http://localhost:4000/`


### Add a project

##### JSON Data

Added in an extremely stupid way, improve it if anyone is interested

1. Get the data from

```
https://api.github.com/repos/BytesClub/<name>/contributors
```
2. Store it in _data/
3. Provide the name in the `.md` file in `_assets`