echo "Starting deploying on local"

echo "Creating docker image"

docker build -t repodetailsapi:v1 .\..\src\

echo "Created docker image"

echo "Running Kubernetes manifests"



kubectl apply -f .\..\src\deployment.yml

kubectl apply -f .\..\src\service.yml

echo "Kubernetes pods and service created"

