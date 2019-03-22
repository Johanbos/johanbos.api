#!/usr/bin/env bash

# imagePullPolicy: Always doesnt work with a kubectl rolling-update
#kubectl rolling-update frontend --image=johanbosnl/johanbos:latest

kubectl apply -f .\Kubernetes.yaml
kubectl rollout status deployment johanbos-deployment