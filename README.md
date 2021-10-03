# SeleniumGridWithDocker
## Configuration
1. To successfully run tests for this project, you must first start the Selenium GRID hub and nodes.
1. To do this, open PowerShell and navigate to the location of the attached docker-compose.yml file (make sure Docker Engine is present on the host system).
1. Then run 'docker-compose up -d' command and check the GRID status (it's usually enough to check http://localhost:4444/grid/console).
## Note
Docker images used to build the Selenium nodes are the debug (non headless) versions, so the executed test scrips can also be visually monitored. To achieve this install i.e. the VNC Viewer and create connections to the nodes declared in the docker-compose.yml file. In this case use localhost:5901 for the chrome node and localhost:5902 for the firefox node (password for both is: secret).
