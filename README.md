# URL-Shortener

## Docker one command
```console
git clone https://github.com/StayFN/URL-Shortener.git && docker build -t shortener ./URL-Shortener/URL-Shortener/ && docker run -p 8080:80 shortener
```

To automatically open in your browser add * to the end of the command:
* Windows "start http://localhost:8080"
* Linux   "xdg-open http://localhost:8080"
* macOS   "open http://localhost:8080"

## Manual
* insert the URL you want to shorten in the "URL"-Field (example: https://www.youtube.com)
* Insert the shortened "Custom Path" (if you leave it empty it will generate one for you)
* Click "Create"
* Copy the Link and Go

![Screenshot](https://i.imgur.com/moDKkRy.png)
