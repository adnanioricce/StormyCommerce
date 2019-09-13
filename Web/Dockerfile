FROM node:12.10.0-alpine
WORKDIR /app
ENV PATH /app/node_modules/.bin:$PATH
COPY . ./
RUN ls -l
# RUN rm -r node_modules
RUN npm install --silent
RUN npm install react-scripts@3.0.1 -g --sile
# RUN install --save typescript @types/node @types/react @types/react-dom @types/jest
RUN npm run build 
ENTRYPOINT ["npm","start"]