export default {
    root: 'NpmJS',
    build: {
        outDir: '../../wwwroot/vite',
        emptyOutDir: true,
        manifest: true,
        assetsDir: '',
        rollupOptions: {
            input: {
                main: './src/index.js',
            },
            output: {
                entryFileNames: '[name].js',
                chunkFileNames: '[name].js',
                assetFileNames: '[name].[ext]'
            }
        },
    },
}