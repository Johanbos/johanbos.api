#!/usr/bin/env bash

kubectl apply -f .\Kubernetes.yaml
kubectl rollout status deployment johanbos-deployment